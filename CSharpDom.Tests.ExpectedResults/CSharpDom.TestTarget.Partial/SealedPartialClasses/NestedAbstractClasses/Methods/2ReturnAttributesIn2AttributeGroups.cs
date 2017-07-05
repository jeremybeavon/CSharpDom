namespace CSharpDom.TestTarget.Partial.SealedPartialClasses.NestedAbstractClasses.Methods
{
    public sealed partial class SealedPartialClassWithNestedAbstractClassWithMethodWith2ReturnAttributesIn2AttributeGroups
    {
        public abstract class Class
        {
            [return: Attribute1]
            [return: Attribute2]
            public void Method()
            {
            }
        }
    }
}
