namespace CSharpDom.TestTarget.Partial.Structs.NestedStructs.NestedSealedClasses
{
    public struct StructWithNestedStructWithNestedSealedPartialClassWith1Attribute
    {
        public struct Struct
        {
            [Attribute1]
            public sealed class NestedClass
            {
            }
        }
    }
}
