namespace CSharpDom.TestTarget.Partial.Structs.NestedStructs.NestedSealedClasses
{
    public struct StructWithNestedStructWithNestedSealedPartialClassWith2AttributesIn2AttributeGroups
    {
        public struct Struct
        {
            [Attribute1]
            [Attribute2]
            public sealed class NestedClass
            {
            }
        }
    }
}
