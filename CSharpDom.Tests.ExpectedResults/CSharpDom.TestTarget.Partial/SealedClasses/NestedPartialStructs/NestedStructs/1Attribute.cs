namespace CSharpDom.TestTarget.Partial.SealedClasses.NestedStructs.NestedStructs
{
    public sealed class SealedClassWithNestedStructWithNestedStructWith1Attribute
    {
        public struct Struct
        {
            [Attribute1]
            public struct NestedStruct
            {
            }
        }
    }
}
