namespace CSharpDom.TestTarget.Partial.SealedClasses.NestedStructs.Methods
{
    public sealed class SealedClassWithNestedStructWithMethodWith2GenericParameters
    {
        public struct Struct
        {
            public Dictionary<TKey, TValue> Method<TKey, TValue>()
            {
                return default(Dictionary<TKey, TValue>);
            }
        }
    }
}
