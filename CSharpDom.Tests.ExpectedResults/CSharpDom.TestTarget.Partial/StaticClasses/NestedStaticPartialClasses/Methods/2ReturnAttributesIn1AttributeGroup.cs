namespace CSharpDom.TestTarget.Partial.StaticClasses.NestedStaticPartialClasses.Methods
{
    public static class StaticClassWithNestedStaticPartialClassWithMethodWith2ReturnAttributesIn1AttributeGroup
    {
        public static partial class Class
        {
            [return: Attribute1, Attribute2]
            public static void Method()
            {
            }
        }
    }
}
