namespace CSharpDom.TestTarget.Partial.PartialClasses.NestedAbstractClasses.Methods
{
    public partial class PartialClassWithNestedAbstractClassWithMethodWith2GenericParameters
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
