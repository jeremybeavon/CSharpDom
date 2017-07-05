namespace CSharpDom.TestTarget.Partial.SealedClasses.NestedAbstractPartialClasses.NestedStaticClasses
{
    public sealed class SealedClassWithNestedAbstractPartialClassWithNestedStaticPartialClassWithGenericParameterGenericParameterConstraint
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
