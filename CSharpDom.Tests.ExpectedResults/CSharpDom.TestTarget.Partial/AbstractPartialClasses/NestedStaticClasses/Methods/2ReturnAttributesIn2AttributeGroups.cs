namespace CSharpDom.TestTarget.Partial.AbstractPartialClasses.NestedStaticClasses.Methods
{
    public abstract partial class AbstractPartialClassWithNestedStaticClassWithMethodWith2ReturnAttributesIn2AttributeGroups
    {
        public static class Class
        {
            [return: Attribute1]
            [return: Attribute2]
            public static void Method()
            {
            }
        }
    }
}
