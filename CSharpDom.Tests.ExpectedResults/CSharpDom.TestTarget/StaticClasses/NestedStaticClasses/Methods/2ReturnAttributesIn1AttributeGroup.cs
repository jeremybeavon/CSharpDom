namespace CSharpDom.TestTarget.StaticClasses.NestedStaticClasses.Methods
{
    public static class StaticClassWithNestedStaticClassWithMethodWith2ReturnAttributesIn1AttributeGroup
    {
        public static class Class
        {
            [return: Attribute1, Attribute2]
            public static void Method()
            {
            }
        }
    }
}
