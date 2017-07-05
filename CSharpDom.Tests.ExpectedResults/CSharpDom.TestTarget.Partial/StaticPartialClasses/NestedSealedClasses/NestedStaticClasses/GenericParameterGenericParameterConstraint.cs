namespace CSharpDom.TestTarget.Partial.StaticPartialClasses.NestedSealedClasses.NestedStaticClasses
{
    public static partial class StaticPartialClassWithNestedSealedClassWithNestedStaticClassWithGenericParameterGenericParameterConstraint
    {
        public sealed class Class
        {
            public static class NestedClass<TKey, TValue>
                where TKey : TValue
            {
            }
        }
    }
}
