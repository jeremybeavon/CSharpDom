namespace CSharpDom.TestTarget.Structs.NestedStructs.NestedSealedClasses
{
    public struct StructWithNestedStructWithNestedSealedClassWith1ImplementedInterface
    {
        public struct Struct
        {
            public sealed class NestedClass : IInterface
            {
            }
        }
    }
}
