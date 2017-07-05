namespace CSharpDom.TestTarget.Partial.AbstractPartialClasses.NestedClasses.Methods
{
    public abstract partial class AbstractPartialClassWithNestedClassWithMethodWithGenericParameterGenericParameterConstraint
    {
        public class Class
        {
            public Dictionary<TKey, TValue> Method<TKey, TValue>()
                where TValue : TKey
            {
                return default(Dictionary<TKey, TValue>);
            }
        }
    }
}
