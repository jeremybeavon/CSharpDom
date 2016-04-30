namespace CSharpDom.TestTarget.Structs.NestedSealedClasses.NestedAbstractClasses
{
    public struct StructWithNestedSealedClassWithNestedAbstractClassWith2AttributesIn2AttributeGroups
    {
        public sealed class Class
        {
            [Attribute1]
            [Attribute2]
            public abstract class NestedClass
            {
            }
        }
    }
}
