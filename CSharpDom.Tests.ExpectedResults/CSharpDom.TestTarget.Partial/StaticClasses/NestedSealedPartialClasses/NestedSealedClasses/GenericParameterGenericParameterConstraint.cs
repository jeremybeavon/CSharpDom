namespace CSharpDom.TestTarget.Partial.StaticClasses.NestedSealedPartialClasses.NestedSealedClasses
{
    public static class StaticClassWithNestedSealedPartialClassWithNestedSealedPartialClassWithGenericParameterGenericParameterConstraint
    {
        public sealed partial class Class
        {
            public sealed class NestedClass<TKey, TValue>
                where TKey : TValue
            {
            }
        }
    }
}
