namespace sTextEditor.Configuration
{
    public sealed class StylesConfiguration
    {
        public XmlConfiguration Xml { get; set; }
        public JsonConfiguration Json { get; set; }
    }

    public sealed class XmlConfiguration
    {
        public ElementStylesConfiguration Default { get; set; }
        public ElementStylesConfiguration Question { get; set; }
        public ElementStylesConfiguration CData { get; set; }
        public ElementStylesConfiguration AspAt { get; set; }
        public ElementStylesConfiguration Asp { get; set; }
        public ElementStylesConfiguration Script { get; set; }
        public ElementStylesConfiguration XmlEnd { get; set; }
        public ElementStylesConfiguration XmlStart { get; set; }
        public ElementStylesConfiguration TagEnd { get; set; }
        public ElementStylesConfiguration Value { get; set; }
        public ElementStylesConfiguration Entity { get; set; }
        public ElementStylesConfiguration Other { get; set; }
        public ElementStylesConfiguration SingleString { get; set; }
        public ElementStylesConfiguration DoubleString { get; set; }
        public ElementStylesConfiguration Number { get; set; }
        public ElementStylesConfiguration AttributeUnknown { get; set; }
        public ElementStylesConfiguration Attribute { get; set; }
        public ElementStylesConfiguration TagUnknown { get; set; }
        public ElementStylesConfiguration Tag { get; set; }
        public ElementStylesConfiguration Comment { get; set; }
        public ElementStylesConfiguration XcComment { get; set; }
    }

    public sealed class JsonConfiguration
    {
        public ElementStylesConfiguration Default { get; set; }
        public ElementStylesConfiguration Number { get; set; }
        public ElementStylesConfiguration String { get; set; }
        public ElementStylesConfiguration StringEol { get; set; }
        public ElementStylesConfiguration PropertyName { get; set; }
        public ElementStylesConfiguration EscapeSequence { get; set; }
        public ElementStylesConfiguration LineComment { get; set; }
        public ElementStylesConfiguration BlockComment { get; set; }
        public ElementStylesConfiguration Operator { get; set; }
        public ElementStylesConfiguration Uri { get; set; }
        public ElementStylesConfiguration CompactIRI { get; set; }
        public ElementStylesConfiguration Keyword { get; set; }
        public ElementStylesConfiguration LdKeyword { get; set; }
        public ElementStylesConfiguration Error { get; set; }
    }

    public sealed class ElementStylesConfiguration
    {
        public string ForeColor { get; set; }
    }
}
