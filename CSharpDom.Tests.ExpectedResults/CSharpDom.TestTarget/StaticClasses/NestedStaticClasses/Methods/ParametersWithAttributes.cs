namespace CSharpDom.TestTarget.StaticClasses.NestedStaticClasses.Methods
{
    public static class StaticClassWithNestedStaticClassWithMethodWithParametersWithAttributes
    {
        public static class Class
        {
            public static void Method([Attribute1]string parameter1, [Attribute2][Attribute3]string parameter2)
            {
            }
        }
    }
}
