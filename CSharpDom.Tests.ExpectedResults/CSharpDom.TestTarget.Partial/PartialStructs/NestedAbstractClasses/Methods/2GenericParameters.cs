namespace CSharpDom.TestTarget.Partial.PartialStructs.NestedAbstractClasses.Methods
{
    public partial struct PartialStructWithWithNestedAbstractClassWithMethodWith2GenericParameters
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
