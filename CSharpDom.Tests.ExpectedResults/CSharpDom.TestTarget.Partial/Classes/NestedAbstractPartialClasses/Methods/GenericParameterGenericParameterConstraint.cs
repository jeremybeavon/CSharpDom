namespace CSharpDom.TestTarget.Partial.Classes.NestedAbstractPartialClasses.Methods
{
    public class ClassWithNestedAbstractPartialClassWithMethodWithGenericParameterGenericParameterConstraint
    {
        public abstract partial class Class
        {
            public Dictionary<TKey, TValue> Method<TKey, TValue>()
                where TValue : TKey
            {
                return default(Dictionary<TKey, TValue>);
            }
        }
    }
}
