namespace CSharpDom.TestTarget.Partial.SealedClasses.NestedStructs.NestedStructs
{
    public sealed class SealedClassWithNestedStructWithNestedStructWith2AttributesIn2AttributeGroups
    {
        public struct Struct
        {
            [Attribute1]
            [Attribute2]
            public struct NestedStruct
            {
            }
        }
    }
}
