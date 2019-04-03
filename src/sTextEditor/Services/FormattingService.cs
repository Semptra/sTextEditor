using System.Xml.Linq;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace sTextEditor.Services
{
    public sealed class FormattingService
    {
        public string FormatAsXml(string text)
        {
            try
            {
                var xml = XDocument.Parse(text);
                return xml.ToString();
            }
            catch
            {
                return text;
            }
        }

        public string FormatAsJson(string text)
        {
            string input = text.Trim();

            if ((input.StartsWith("{") && input.EndsWith("}")) ||
                (input.StartsWith("[") && input.EndsWith("]")))
            {
                try
                {
                    var json = JToken.Parse(input);
                    return json.ToString(Formatting.Indented);
                }
                catch
                {
                    return text;
                }
            }
            else
            {
                return text;
            }
        }
    }
}
