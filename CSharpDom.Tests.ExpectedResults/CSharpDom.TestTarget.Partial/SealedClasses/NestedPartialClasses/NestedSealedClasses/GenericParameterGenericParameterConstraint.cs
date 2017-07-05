namespace CSharpDom.TestTarget.Partial.SealedClasses.NestedPartialClasses.NestedSealedClasses
{
    public sealed class SealedClassWithNestedPartialClassWithNestedSealedPartialClassWithGenericParameterGenericParameterConstraint
    {
        public partial class Class
        {
            public sealed class NestedClass<TKey, TValue>
                where TKey : TValue
            {
            }
        }
    }
}
