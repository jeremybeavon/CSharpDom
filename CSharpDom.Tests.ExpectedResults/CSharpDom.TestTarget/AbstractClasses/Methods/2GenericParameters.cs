namespace CSharpDom.TestTarget.AbstractClasses.Methods
{
    public abstract class AbstractClassWithMethodWith2GenericParameters
    {
        public Dictionary<TKey, TValue> Method<TKey, TValue>()
        {
            return default(Dictionary<TKey, TValue>);
        }
    }
}
