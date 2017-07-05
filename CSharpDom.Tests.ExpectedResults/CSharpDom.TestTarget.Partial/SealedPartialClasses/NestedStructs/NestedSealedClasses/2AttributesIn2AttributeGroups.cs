namespace CSharpDom.TestTarget.Partial.SealedPartialClasses.NestedStructs.NestedSealedClasses
{
    public sealed partial class SealedPartialClassWithNestedStructWithNestedSealedClassWith2AttributesIn2AttributeGroups
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
