namespace CSharpDom.TestTarget.Partial.SealedPartialClasses.NestedStructs.Methods
{
    public sealed partial class SealedPartialClassWithNestedStructWithMethodWith2GenericParameters
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
