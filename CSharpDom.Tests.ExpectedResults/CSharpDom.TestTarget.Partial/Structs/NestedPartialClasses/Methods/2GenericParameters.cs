namespace CSharpDom.TestTarget.Partial.Structs.NestedPartialClasses.Methods
{
    public struct StructWithNestedPartialClassWithMethodWith2GenericParameters
    {
        public partial class Class
        {
            public Dictionary<TKey, TValue> Method<TKey, TValue>()
            {
                return default(Dictionary<TKey, TValue>);
            }
        }
    }
}
