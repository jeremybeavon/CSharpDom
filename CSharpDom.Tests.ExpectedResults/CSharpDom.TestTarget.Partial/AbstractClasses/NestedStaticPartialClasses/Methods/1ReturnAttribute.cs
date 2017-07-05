namespace CSharpDom.TestTarget.Partial.AbstractClasses.NestedStaticPartialClasses.Methods
{
    public abstract class AbstractClassWithNestedStaticPartialClassWithMethodWith1ReturnAttribute
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
