namespace CSharpDom.TestTarget.Partial.PartialStructs.Constructors
{
    public partial struct PartialStructWithConstructorWithParametersWithAttributes
    {
        public PartialStructWithConstructorWithParametersWithAttributes([Attribute1]string parameter1, [Attribute2][Attribute3]string parameter2)
        {
        }
    }
}
