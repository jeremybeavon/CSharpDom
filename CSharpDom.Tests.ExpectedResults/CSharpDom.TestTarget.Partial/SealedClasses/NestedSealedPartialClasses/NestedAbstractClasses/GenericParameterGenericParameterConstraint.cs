namespace CSharpDom.TestTarget.Partial.SealedClasses.NestedSealedPartialClasses.NestedAbstractClasses
{
    public sealed class SealedClassWithNestedSealedPartialClassWithNestedAbstractPartialClassWithGenericParameterGenericParameterConstraint
    {
        public sealed partial class Class
        {
            public abstract class NestedClass<TKey, TValue>
                where TKey : TValue
            {
            }
        }
    }
}
