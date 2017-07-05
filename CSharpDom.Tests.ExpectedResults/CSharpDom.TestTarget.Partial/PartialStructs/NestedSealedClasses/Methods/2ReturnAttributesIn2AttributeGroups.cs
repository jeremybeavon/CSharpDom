namespace CSharpDom.TestTarget.Partial.PartialStructs.NestedSealedClasses.Methods
{
    public partial struct PartialStructWithWithNestedSealedClassWithMethodWith2ReturnAttributesIn2AttributeGroups
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
