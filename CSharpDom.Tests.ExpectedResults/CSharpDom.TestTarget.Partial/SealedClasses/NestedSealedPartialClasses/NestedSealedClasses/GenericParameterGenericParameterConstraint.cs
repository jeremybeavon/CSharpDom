namespace CSharpDom.TestTarget.Partial.SealedClasses.NestedSealedPartialClasses.NestedSealedClasses
{
    public sealed class SealedClassWithNestedSealedPartialClassWithNestedSealedPartialClassWithGenericParameterGenericParameterConstraint
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
