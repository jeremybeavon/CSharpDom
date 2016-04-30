namespace CSharpDom.TestTarget.StaticClasses.NestedSealedClasses.Methods
{
    public static class StaticClassWithNestedSealedClassWithMethodWith1ReturnAttribute
    {
        public sealed class Class
        {
            [return: Attribute1]
            public void Method()
            {
            }
        }
    }
}
