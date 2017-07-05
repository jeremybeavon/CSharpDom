namespace CSharpDom.TestTarget.Partial.AbstractPartialClasses.NestedSealedClasses.Methods
{
    public abstract partial class AbstractPartialClassWithNestedSealedClassWithMethodWith2ReturnAttributesIn1AttributeGroup
    {
        public sealed class Class
        {
            [return: Attribute1, Attribute2]
            public void Method()
            {
            }
        }
    }
}
