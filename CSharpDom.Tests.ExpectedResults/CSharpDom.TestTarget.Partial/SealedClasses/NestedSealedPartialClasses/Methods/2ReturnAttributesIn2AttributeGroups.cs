namespace CSharpDom.TestTarget.Partial.SealedClasses.NestedSealedPartialClasses.Methods
{
    public sealed class SealedClassWithNestedSealedPartialClassWithMethodWith2ReturnAttributesIn2AttributeGroups
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
