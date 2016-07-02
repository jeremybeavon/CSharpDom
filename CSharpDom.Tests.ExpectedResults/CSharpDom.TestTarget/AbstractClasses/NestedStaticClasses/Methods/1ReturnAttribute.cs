namespace CSharpDom.TestTarget.AbstractClasses.NestedStaticClasses.Methods
{
    public abstract class AbstractClassWithNestedStaticClassWithMethodWith1ReturnAttribute
    {
        public static class Class
        {
            [return: Attribute1]
            public static void Method()
            {
            }
        }
    }
}
