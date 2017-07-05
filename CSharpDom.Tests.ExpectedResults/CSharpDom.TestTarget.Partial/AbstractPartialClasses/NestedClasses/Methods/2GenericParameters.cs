namespace CSharpDom.TestTarget.Partial.AbstractPartialClasses.NestedClasses.Methods
{
    public abstract partial class AbstractPartialClassWithNestedClassWithMethodWith2GenericParameters
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
