namespace CSharpDom.TestTarget.Structs.NestedSealedClasses.NestedSealedClasses
{
    public struct StructWithNestedSealedClassWithNestedSealedClassWith2AttributesIn2AttributeGroups
    {
        public sealed class Class
        {
            [Attribute1]
            [Attribute2]
            public sealed class NestedClass
            {
            }
        }
    }
}
