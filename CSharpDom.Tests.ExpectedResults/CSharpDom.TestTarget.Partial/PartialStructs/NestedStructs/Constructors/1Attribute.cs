namespace CSharpDom.TestTarget.Partial.PartialStructs.NestedStructs.Constructors
{
    public partial struct PartialStructWithWithNestedStructWithConstructorWith1Attribute
    {
        public struct Struct
        {
            [Attribute1]
            public Struct(string text)
            {
            }
        }
    }
}
