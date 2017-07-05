namespace CSharpDom.TestTarget.Partial.Structs.NestedSealedPartialClasses.Methods
{
    public struct StructWithNestedSealedPartialClassWithMethodWith1ReturnAttribute
    {
        public sealed partial class Class
        {
            [return: Attribute1]
            public void Method()
            {
            }
        }
    }
}
