namespace CSharpDom.TestTarget.Partial.StaticPartialClasses.NestedStaticClasses.NestedSealedClasses
{
    public static partial class StaticPartialClassWithNestedStaticClassWithNestedSealedClassWithGenericParameterGenericParameterConstraint
    {
        public static class Class
        {
            public sealed class NestedClass<TKey, TValue>
                where TKey : TValue
            {
            }
        }
    }
}
