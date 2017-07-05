namespace CSharpDom.TestTarget.Partial.Classes.NestedStaticPartialClasses.Methods
{
    public class ClassWithNestedStaticPartialClassWithMethodWith1ReturnAttribute
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
