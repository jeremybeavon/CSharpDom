namespace CSharpDom.TestTarget.SealedClasses.NestedAbstractClasses.Methods
{
    public sealed class SealedClassWithNestedAbstractClassWithMethodWith2GenericParameters
    {
        public abstract class Class
        {
            public Dictionary<TKey, TValue> Method<TKey, TValue>()
            {
                return default(Dictionary<TKey, TValue>);
            }
        }
    }
}
