namespace CSharpDom.TestTarget.Partial.SealedClasses.NestedAbstractPartialClasses.Methods
{
    public sealed class SealedClassWithNestedAbstractPartialClassWithMethodWith2ReturnAttributesIn1AttributeGroup
    {
        public abstract partial class Class
        {
            [return: Attribute1, Attribute2]
            public void Method()
            {
            }
        }
    }
}
