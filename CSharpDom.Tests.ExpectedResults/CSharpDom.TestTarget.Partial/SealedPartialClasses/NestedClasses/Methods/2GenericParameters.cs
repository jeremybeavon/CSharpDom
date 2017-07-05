namespace CSharpDom.TestTarget.Partial.SealedPartialClasses.NestedClasses.Methods
{
    public sealed partial class SealedPartialClassWithNestedClassWithMethodWith2GenericParameters
    {
        public class Class
        {
            public Dictionary<TKey, TValue> Method<TKey, TValue>()
            {
                return default(Dictionary<TKey, TValue>);
            }
        }
    }
}
