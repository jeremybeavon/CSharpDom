namespace CSharpDom.TestTarget.Partial.SealedPartialClasses.NestedStaticClasses.Methods
{
    public sealed partial class SealedPartialClassWithNestedStaticClassWithMethodWith2ReturnAttributesIn2AttributeGroups
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
