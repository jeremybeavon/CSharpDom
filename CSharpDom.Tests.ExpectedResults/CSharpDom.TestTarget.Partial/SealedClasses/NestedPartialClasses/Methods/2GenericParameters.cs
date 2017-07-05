namespace CSharpDom.TestTarget.Partial.SealedClasses.NestedPartialClasses.Methods
{
    public sealed class SealedClassWithNestedPartialClassWithMethodWith2GenericParameters
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
