namespace CSharpDom.TestTarget.Partial.AbstractPartialClasses.NestedSealedClasses.Methods
{
    public abstract partial class AbstractPartialClassWithNestedSealedClassWithMethodWith2ReturnAttributesIn2AttributeGroups
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
