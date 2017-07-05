namespace CSharpDom.TestTarget.Partial.PartialClasses.NestedStructs.Methods
{
    public partial class PartialClassWithNestedStructWithMethodWith2GenericParameters
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
