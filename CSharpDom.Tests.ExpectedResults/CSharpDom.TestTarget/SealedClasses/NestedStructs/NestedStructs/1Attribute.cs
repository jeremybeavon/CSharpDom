namespace CSharpDom.TestTarget.SealedClasses.NestedStructs.NestedStructs
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
