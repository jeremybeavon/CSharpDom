namespace CSharpDom.TestTarget.Structs.NestedSealedClasses.NestedStructs
{
    public struct StructWithNestedSealedClassWithNestedStructWith2GenericParameters
    {
        public sealed class Class
        {
            public struct NestedStruct<TKey, TValue>
            {
            }
        }
    }
}
