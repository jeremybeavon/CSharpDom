namespace CSharpDom.TestTarget.StaticClasses.NestedAbstractClasses.Methods
{
    public static class StaticClassWithNestedAbstractClassWithMethodWith1ReturnAttribute
    {
        public abstract class Class
        {
            [return: Attribute1]
            public void Method()
            {
            }
        }
    }
}
