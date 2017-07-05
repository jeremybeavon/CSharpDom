namespace CSharpDom.TestTarget.Partial.Structs.NestedPartialClasses.Methods
{
    public struct StructWithNestedPartialClassWithMethodWith1ReturnAttribute
    {
        public partial class Class
        {
            [return: Attribute1]
            public void Method()
            {
            }
        }
    }
}
