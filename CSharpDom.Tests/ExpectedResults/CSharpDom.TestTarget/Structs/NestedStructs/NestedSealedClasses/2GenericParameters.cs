namespace CSharpDom.TestTarget.Structs.NestedStructs.NestedSealedClasses
{
    public struct StructWithNestedStructWithNestedSealedClassWith2GenericParameters
    {
        public struct Struct
        {
            public sealed class NestedClass<TKey, TValue>
            {
            }
        }
    }
}
