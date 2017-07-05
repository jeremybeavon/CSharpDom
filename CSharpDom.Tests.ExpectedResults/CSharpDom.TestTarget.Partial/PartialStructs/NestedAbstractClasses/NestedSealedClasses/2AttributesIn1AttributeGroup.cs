namespace CSharpDom.TestTarget.Partial.PartialStructs.NestedAbstractClasses.NestedSealedClasses
{
    public partial struct PartialStructWithWithNestedAbstractClassWithNestedSealedClassWith2AttributesIn1AttributeGroup
    {
        public abstract class Class
        {
            [Attribute1, Attribute2]
            public sealed class NestedClass
            {
            }
        }
    }
}
