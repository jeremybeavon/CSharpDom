namespace CSharpDom.TestTarget.SealedClasses.NestedSealedClasses.NestedAbstractClasses
{
    public sealed class SealedClassWithNestedSealedClassWithNestedAbstractClassWithGenericParameterGenericParameterConstraint
    {
        public sealed class Class
        {
            public abstract class NestedClass<TKey, TValue>
                where TKey : TValue
            {
            }
        }
    }
}
