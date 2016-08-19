using System.Collections;
using System.Xml;

namespace MBINCompiler.Models
{
    public class NMSTemplate
    {
        public XmlElement AppendToXml(XmlElement parentElement, XmlDocument document)
        {
            XmlElement el = null;
            if (parentElement != null)
                el = (XmlElement)parentElement.AppendChild(document.CreateElement("Data"));
            else
                el = (XmlElement)document.AppendChild(document.CreateElement("Data"));

            var type = GetType();
            el.SetAttribute("template", type.Name);

            var fields = type.GetFields();
            foreach (var field in fields)
            {
                if (field.Name.StartsWith("Padding"))
                    continue;
                var fieldName = field.Name;
                var fieldType = field.FieldType.Name;

                switch (fieldType)
                {
                    case "String":
                    case "Single":
                    case "Boolean":
                    case "Int16":
                    case "Int32":
                        var prop = (XmlElement)el.AppendChild(document.CreateElement("Property"));
                        prop.SetAttribute("name", fieldName);
                        var value = field.GetValue(this).ToString();
                        var valuesMethod = type.GetMethod(field.Name + "Values"); // if we have an "xxxValues()" method in the struct, use that to get the value name
                        if (valuesMethod != null)
                        {
                            string[] values = (string[])valuesMethod.Invoke(this, null);
                            value = values[(int)field.GetValue(this)];
                        }
                        prop.SetAttribute("value", value);
                        break;

                    case "Byte[]":
                        break; // todo
                    case "List`1":
                        var prop2 = (XmlElement)el.AppendChild(document.CreateElement("Property"));
                        prop2.SetAttribute("name", fieldName);

                        IList templates = (IList)field.GetValue(this);
                        foreach (var template in templates)
                            ((NMSTemplate)template).AppendToXml(prop2, document);

                        break;

                    default:
                        if (field.FieldType.BaseType.Name == "NMSTemplate")
                        {
                            NMSTemplate template = (NMSTemplate)field.GetValue(this);
                            var element = template.AppendToXml(el, document);
                            element.SetAttribute("name", fieldName);
                        }
                        break;
                }
            }

            return el;
        }
    }
}