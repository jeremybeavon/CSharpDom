namespace CSharpDom.TestTarget.Partial.StaticClasses.NestedStaticPartialClasses.Methods
{
    public static class StaticClassWithNestedStaticPartialClassWithMethodWith2ReturnAttributesIn2AttributeGroups
    {
        public static partial class Class
        {
            [return: Attribute1]
            [return: Attribute2]
            public static void Method()
            {
            }
        }
    }
}
