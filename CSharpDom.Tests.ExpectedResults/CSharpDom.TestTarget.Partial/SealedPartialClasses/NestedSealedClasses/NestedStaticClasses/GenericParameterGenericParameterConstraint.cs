namespace CSharpDom.TestTarget.Partial.SealedPartialClasses.NestedSealedClasses.NestedStaticClasses
{
    public sealed partial class SealedPartialClassWithNestedSealedClassWithNestedStaticClassWithGenericParameterGenericParameterConstraint
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
