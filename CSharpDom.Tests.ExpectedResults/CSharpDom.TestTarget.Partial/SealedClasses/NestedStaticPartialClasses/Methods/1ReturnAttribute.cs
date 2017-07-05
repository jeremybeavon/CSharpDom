namespace CSharpDom.TestTarget.Partial.SealedClasses.NestedStaticPartialClasses.Methods
{
    public sealed class SealedClassWithNestedStaticPartialClassWithMethodWith1ReturnAttribute
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
