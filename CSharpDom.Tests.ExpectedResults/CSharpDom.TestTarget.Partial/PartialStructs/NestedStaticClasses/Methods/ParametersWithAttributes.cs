namespace CSharpDom.TestTarget.Partial.PartialStructs.NestedStaticClasses.Methods
{
    public partial struct PartialStructWithWithNestedStaticClassWithMethodWithParametersWithAttributes
    {
        public static class Class
        {
            public static void Method([Attribute1]string parameter1, [Attribute2][Attribute3]string parameter2)
            {
            }
        }
    }
}
