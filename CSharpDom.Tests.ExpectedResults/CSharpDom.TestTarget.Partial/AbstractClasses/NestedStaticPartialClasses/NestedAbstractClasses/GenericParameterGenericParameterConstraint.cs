namespace CSharpDom.TestTarget.Partial.AbstractClasses.NestedStaticPartialClasses.NestedAbstractClasses
{
    public abstract class AbstractClassWithNestedStaticPartialClassWithNestedAbstractPartialClassWithGenericParameterGenericParameterConstraint
    {
        public static partial class Class
        {
            public abstract class NestedClass<TKey, TValue>
                where TKey : TValue
            {
            }
        }
    }
}
