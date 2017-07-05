namespace CSharpDom.TestTarget.Partial.Structs.NestedAbstractPartialClasses.Methods
{
    public struct StructWithNestedAbstractPartialClassWithMethodWith1ReturnAttribute
    {
        public abstract partial class Class
        {
            [return: Attribute1]
            public void Method()
            {
            }
        }
    }
}
