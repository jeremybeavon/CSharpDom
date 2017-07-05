namespace CSharpDom.TestTarget.Partial.StaticPartialClasses.NestedAbstractClasses.NestedStaticClasses
{
    public static partial class StaticPartialClassWithNestedAbstractClassWithNestedStaticClassWithGenericParameterGenericParameterConstraint
    {
        public abstract class Class
        {
            public static class NestedClass<TKey, TValue>
                where TKey : TValue
            {
            }
        }
    }
}
