namespace CSharpDom.TestTarget.Partial.StaticPartialClasses.NestedStaticClasses.NestedAbstractClasses
{
    public static partial class StaticPartialClassWithNestedStaticClassWithNestedAbstractClassWithGenericParameterGenericParameterConstraint
    {
        public static class Class
        {
            public abstract class NestedClass<TKey, TValue>
                where TKey : TValue
            {
            }
        }
    }
}
