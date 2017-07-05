namespace CSharpDom.TestTarget.Partial.SealedPartialClasses.NestedAbstractClasses.NestedSealedClasses
{
    public sealed partial class SealedPartialClassWithNestedAbstractClassWithNestedSealedClassWithGenericParameterGenericParameterConstraint
    {
        public abstract class Class
        {
            public sealed class NestedClass<TKey, TValue>
                where TKey : TValue
            {
            }
        }
    }
}
