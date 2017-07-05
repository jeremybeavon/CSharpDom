namespace CSharpDom.TestTarget.Partial.AbstractClasses.NestedAbstractPartialClasses.NestedStaticClasses
{
    public abstract class AbstractClassWithNestedAbstractPartialClassWithNestedStaticPartialClassWithGenericParameterGenericParameterConstraint
    {
        public abstract partial class Class
        {
            public static class NestedClass<TKey, TValue>
                where TKey : TValue
            {
            }
        }
    }
}
