namespace CSharpDom.TestTarget.AbstractClasses.NestedSealedClasses.Methods
{
    public abstract class AbstractClassWithNestedSealedClassWithMethodWith2GenericParameters
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
