namespace CSharpDom.TestTarget.Partial.StaticClasses.NestedStaticPartialClasses.NestedAbstractClasses
{
    public static class StaticClassWithNestedStaticPartialClassWithNestedAbstractPartialClassWithGenericParameterGenericParameterConstraint
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
