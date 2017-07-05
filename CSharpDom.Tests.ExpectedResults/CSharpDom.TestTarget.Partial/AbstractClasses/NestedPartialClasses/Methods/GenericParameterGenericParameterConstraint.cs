namespace CSharpDom.TestTarget.Partial.AbstractClasses.NestedPartialClasses.Methods
{
    public abstract class AbstractClassWithNestedPartialClassWithMethodWithGenericParameterGenericParameterConstraint
    {
        public partial class Class
        {
            public Dictionary<TKey, TValue> Method<TKey, TValue>()
                where TValue : TKey
            {
                return default(Dictionary<TKey, TValue>);
            }
        }
    }
}
