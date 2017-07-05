namespace CSharpDom.TestTarget.Partial.SealedPartialClasses.NestedSealedClasses.NestedSealedClasses
{
    public sealed partial class SealedPartialClassWithNestedSealedClassWithNestedSealedClassWithGenericParameterGenericParameterConstraint
    {
        public sealed class Class
        {
            public sealed class NestedClass<TKey, TValue>
                where TKey : TValue
            {
            }
        }
    }
}
