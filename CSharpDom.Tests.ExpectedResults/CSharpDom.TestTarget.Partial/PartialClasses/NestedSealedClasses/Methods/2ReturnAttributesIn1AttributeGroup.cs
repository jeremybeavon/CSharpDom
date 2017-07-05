namespace CSharpDom.TestTarget.Partial.PartialClasses.NestedSealedClasses.Methods
{
    public partial class PartialClassWithNestedSealedClassWithMethodWith2ReturnAttributesIn1AttributeGroup
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
