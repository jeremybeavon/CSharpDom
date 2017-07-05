namespace CSharpDom.TestTarget.Partial.SealedClasses.NestedStaticPartialClasses.NestedStaticClasses
{
    public sealed class SealedClassWithNestedStaticPartialClassWithNestedStaticPartialClassWithGenericParameterGenericParameterConstraint
    {
        public static partial class Class
        {
            public static class NestedClass<TKey, TValue>
                where TKey : TValue
            {
            }
        }
    }
}
