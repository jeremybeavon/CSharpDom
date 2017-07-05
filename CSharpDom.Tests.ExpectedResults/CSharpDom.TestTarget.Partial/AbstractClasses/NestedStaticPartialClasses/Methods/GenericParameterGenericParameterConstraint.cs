namespace CSharpDom.TestTarget.Partial.AbstractClasses.NestedStaticPartialClasses.Methods
{
    public abstract class AbstractClassWithNestedStaticPartialClassWithMethodWithGenericParameterGenericParameterConstraint
    {
        public static partial class Class
        {
            public static Dictionary<TKey, TValue> Method<TKey, TValue>()
                where TValue : TKey
            {
                return default(Dictionary<TKey, TValue>);
            }
        }
    }
}
