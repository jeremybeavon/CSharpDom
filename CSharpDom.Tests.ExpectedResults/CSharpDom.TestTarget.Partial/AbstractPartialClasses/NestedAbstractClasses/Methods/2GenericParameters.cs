namespace CSharpDom.TestTarget.Partial.AbstractPartialClasses.NestedAbstractClasses.Methods
{
    public abstract partial class AbstractPartialClassWithNestedAbstractClassWithMethodWith2GenericParameters
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
