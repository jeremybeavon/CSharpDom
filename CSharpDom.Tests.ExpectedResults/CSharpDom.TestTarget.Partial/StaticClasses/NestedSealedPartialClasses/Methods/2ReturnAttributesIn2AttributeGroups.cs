namespace CSharpDom.TestTarget.Partial.StaticClasses.NestedSealedPartialClasses.Methods
{
    public static class StaticClassWithNestedSealedPartialClassWithMethodWith2ReturnAttributesIn2AttributeGroups
    {
        public sealed partial class Class
        {
            [return: Attribute1]
            [return: Attribute2]
            public void Method()
            {
            }
        }
    }
}
