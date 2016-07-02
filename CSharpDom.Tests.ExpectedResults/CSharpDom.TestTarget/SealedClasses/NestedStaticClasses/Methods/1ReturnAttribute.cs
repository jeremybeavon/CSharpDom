namespace CSharpDom.TestTarget.SealedClasses.NestedStaticClasses.Methods
{
    public sealed class SealedClassWithNestedStaticClassWithMethodWith1ReturnAttribute
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
