namespace CSharpDom.TestTarget.SealedClasses.NestedStructs.NestedSealedClasses
{
    public sealed class SealedClassWithNestedStructWithNestedSealedClassWithBaseClass
    {
        public struct Struct
        {
            public sealed class NestedClass : BaseClass
            {
            }
        }
    }
}
