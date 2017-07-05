namespace CSharpDom.TestTarget.Partial.StaticClasses.NestedStaticPartialClasses.Methods
{
    public static class StaticClassWithNestedStaticPartialClassWithMethodWith1ReturnAttribute
    {
        public static partial class Class
        {
            [return: Attribute1]
            public static void Method()
            {
            }
        }
    }
}
