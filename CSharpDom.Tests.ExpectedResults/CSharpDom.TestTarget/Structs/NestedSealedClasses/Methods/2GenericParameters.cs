namespace CSharpDom.TestTarget.Structs.NestedSealedClasses.Methods
{
    public struct StructWithNestedSealedClassWithMethodWith2GenericParameters
    {
        public sealed class Class
        {
            public Dictionary<TKey, TValue> Method<TKey, TValue>()
            {
                return default(Dictionary<TKey, TValue>);
            }
        }
    }
}
