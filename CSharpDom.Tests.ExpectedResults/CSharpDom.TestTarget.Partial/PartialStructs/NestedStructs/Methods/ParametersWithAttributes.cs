namespace CSharpDom.TestTarget.Partial.PartialStructs.NestedStructs.Methods
{
    public partial struct PartialStructWithWithNestedStructWithMethodWithParametersWithAttributes
    {
        public struct Struct
        {
            public void Method([Attribute1]string parameter1, [Attribute2][Attribute3]string parameter2)
            {
            }
        }
    }
}
