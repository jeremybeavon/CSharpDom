namespace CSharpDom.TestTarget.Partial.SealedPartialClasses.NestedStructs.NestedStructs
{
    public sealed partial class SealedPartialClassWithNestedStructWithNestedStructWith2AttributesIn1AttributeGroup
    {
        public struct Struct
        {
            [Attribute1, Attribute2]
            public struct NestedStruct
            {
            }
        }
    }
}
