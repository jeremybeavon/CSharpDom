namespace CSharpDom.TestTarget.Partial.PartialStructs.NestedStructs.Constructors
{
    public partial struct PartialStructWithWithNestedStructWithConstructorWithParametersWithAttributes
    {
        public struct Struct
        {
            public Struct([Attribute1]string parameter1, [Attribute2][Attribute3]string parameter2)
            {
            }
        }
    }
}
