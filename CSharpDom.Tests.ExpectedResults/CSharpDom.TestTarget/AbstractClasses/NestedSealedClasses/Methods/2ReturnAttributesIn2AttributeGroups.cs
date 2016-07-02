namespace CSharpDom.TestTarget.AbstractClasses.NestedSealedClasses.Methods
{
    public abstract class AbstractClassWithNestedSealedClassWithMethodWith2ReturnAttributesIn2AttributeGroups
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
