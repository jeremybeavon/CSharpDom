namespace CSharpDom.TestTarget.Partial.StaticPartialClasses.NestedStaticClasses.Methods
{
    public static partial class StaticPartialClassWithNestedStaticClassWithMethodWithParametersWithAttributes
    {
        public static class Class
        {
            public static void Method([Attribute1]string parameter1, [Attribute2][Attribute3]string parameter2)
            {
            }
        }
    }
}
