namespace CSharpDom.TestTarget.Partial.SealedClasses.NestedStructs.NestedSealedClasses
{
    public sealed class SealedClassWithNestedStructWithNestedSealedPartialClassWith1Attribute
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
