namespace CSharpDom.TestTarget.Partial.StaticClasses.NestedAbstractPartialClasses.Methods
{
    public static class StaticClassWithNestedAbstractPartialClassWithMethodWith2ReturnAttributesIn2AttributeGroups
    {
        public abstract partial class Class
        {
            [return: Attribute1]
            [return: Attribute2]
            public void Method()
            {
            }
        }
    }
}
