namespace CSharpDom.TestTarget.SealedClasses.NestedStructs.NestedSealedClasses
{
    public sealed class SealedClassWithNestedStructWithPrivateNestedSealedClass
    {
        public struct Struct
        {
            private sealed class NestedClass
            {
            }
        }
    }
}
