namespace CSharpDom.TestTarget.Partial.SealedClasses.NestedPartialClasses.Methods
{
    public sealed class SealedClassWithNestedPartialClassWithMethodWith2ReturnAttributesIn2AttributeGroups
    {
        public partial class Class
        {
            [return: Attribute1]
            [return: Attribute2]
            public void Method()
            {
            }
        }
    }
}
