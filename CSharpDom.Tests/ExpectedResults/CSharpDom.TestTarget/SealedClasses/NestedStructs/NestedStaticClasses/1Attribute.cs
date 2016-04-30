namespace CSharpDom.TestTarget.SealedClasses.NestedStructs.NestedStaticClasses
{
    public sealed class SealedClassWithNestedStructWithNestedStaticClassWith1Attribute
    {
        public struct Struct
        {
            [Attribute1]
            public static class NestedClass
            {
            }
        }
    }
}
