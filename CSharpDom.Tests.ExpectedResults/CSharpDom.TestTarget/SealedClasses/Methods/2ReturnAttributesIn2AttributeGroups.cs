namespace CSharpDom.TestTarget.SealedClasses.Methods
{
    public sealed class SealedClassWithMethodWith2ReturnAttributesIn2AttributeGroups
    {
        [return: Attribute1]
        [return: Attribute2]
        public void Method()
        {
        }
    }
}
