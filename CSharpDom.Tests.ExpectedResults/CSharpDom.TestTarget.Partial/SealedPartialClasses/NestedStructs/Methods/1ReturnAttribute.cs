namespace CSharpDom.TestTarget.Partial.SealedPartialClasses.NestedStructs.Methods
{
    public sealed partial class SealedPartialClassWithNestedStructWithMethodWith1ReturnAttribute
    {
        public struct Struct
        {
            [return: Attribute1]
            public void Method()
            {
            }
        }
    }
}
