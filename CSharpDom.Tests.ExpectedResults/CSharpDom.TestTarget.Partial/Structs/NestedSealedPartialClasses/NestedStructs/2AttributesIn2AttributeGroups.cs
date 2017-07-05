namespace CSharpDom.TestTarget.Partial.Structs.NestedSealedPartialClasses.NestedStructs
{
    public struct StructWithNestedSealedPartialClassWithNestedStructWith2AttributesIn2AttributeGroups
    {
        public sealed partial class Class
        {
            [Attribute1]
            [Attribute2]
            public struct NestedStruct
            {
            }
        }
    }
}
