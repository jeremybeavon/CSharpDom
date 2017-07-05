namespace CSharpDom.TestTarget.Partial.StaticClasses.NestedAbstractPartialClasses.Methods
{
    public static class StaticClassWithNestedAbstractPartialClassWithMethodWith1ReturnAttribute
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
