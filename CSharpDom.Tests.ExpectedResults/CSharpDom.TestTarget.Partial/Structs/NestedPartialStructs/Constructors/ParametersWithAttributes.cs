namespace CSharpDom.TestTarget.Partial.Structs.NestedStructs.Constructors
{
    public struct StructWithNestedStructWithConstructorWithParametersWithAttributes
    {
        public struct Struct
        {
            public Struct([Attribute1]string parameter1, [Attribute2][Attribute3]string parameter2)
            {
            }
        }
    }
}
