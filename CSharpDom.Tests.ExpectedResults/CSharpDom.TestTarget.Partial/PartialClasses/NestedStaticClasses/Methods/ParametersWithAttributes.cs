namespace CSharpDom.TestTarget.Partial.PartialClasses.NestedStaticClasses.Methods
{
    public partial class PartialClassWithNestedStaticClassWithMethodWithParametersWithAttributes
    {
        public static class Class
        {
            public static void Method([Attribute1]string parameter1, [Attribute2][Attribute3]string parameter2)
            {
            }
        }
    }
}
