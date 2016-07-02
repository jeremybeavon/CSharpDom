namespace CSharpDom.TestTarget.SealedClasses.NestedSealedClasses.Methods
{
    public sealed class SealedClassWithNestedSealedClassWithMethodWith2ReturnAttributesIn1AttributeGroup
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
