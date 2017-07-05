namespace CSharpDom.TestTarget.Partial.StaticClasses.NestedSealedPartialClasses.Methods
{
    public static class StaticClassWithNestedSealedPartialClassWithMethodWith1ReturnAttribute
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
