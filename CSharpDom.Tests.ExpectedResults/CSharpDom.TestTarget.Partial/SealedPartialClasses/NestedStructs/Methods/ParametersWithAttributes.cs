namespace CSharpDom.TestTarget.Partial.SealedPartialClasses.NestedStructs.Methods
{
    public sealed partial class SealedPartialClassWithNestedStructWithMethodWithParametersWithAttributes
    {
        public struct Struct
        {
            public void Method([Attribute1]string parameter1, [Attribute2][Attribute3]string parameter2)
            {
            }
        }
    }
}
