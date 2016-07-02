namespace CSharpDom.TestTarget.Structs.NestedAbstractClasses.NestedSealedClasses
{
    public struct StructWithNestedAbstractClassWithNestedSealedClassWith2AttributesIn1AttributeGroup
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
