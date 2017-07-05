namespace CSharpDom.TestTarget.Partial.SealedClasses.NestedSealedPartialClasses.Methods
{
    public sealed class SealedClassWithNestedSealedPartialClassWithMethodWith2ReturnAttributesIn1AttributeGroup
    {
        public sealed partial class Class
        {
            [return: Attribute1, Attribute2]
            public void Method()
            {
            }
        }
    }
}
