namespace CSharpDom.TestTarget.Partial.StaticClasses.NestedSealedPartialClasses.NestedStaticClasses
{
    public static class StaticClassWithNestedSealedPartialClassWithNestedStaticPartialClassWithGenericParameterGenericParameterConstraint
    {
        public sealed partial class Class
        {
            public static class NestedClass<TKey, TValue>
                where TKey : TValue
            {
            }
        }
    }
}
