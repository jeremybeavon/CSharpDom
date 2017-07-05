namespace CSharpDom.TestTarget.Partial.SealedClasses.NestedAbstractPartialClasses.Methods
{
    public sealed class SealedClassWithNestedAbstractPartialClassWithMethodWith2ReturnAttributesIn2AttributeGroups
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
