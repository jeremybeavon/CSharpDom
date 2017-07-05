namespace CSharpDom.TestTarget.Partial.SealedPartialClasses.NestedSealedClasses.Methods
{
    public sealed partial class SealedPartialClassWithNestedSealedClassWithMethodWith2ReturnAttributesIn2AttributeGroups
    {
        public sealed class Class
        {
            [return: Attribute1]
            [return: Attribute2]
            public void Method()
            {
            }
        }
    }
}
