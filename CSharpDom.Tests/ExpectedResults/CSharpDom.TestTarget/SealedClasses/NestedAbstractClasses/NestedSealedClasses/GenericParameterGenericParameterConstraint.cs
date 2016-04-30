namespace CSharpDom.TestTarget.SealedClasses.NestedAbstractClasses.NestedSealedClasses
{
    public sealed class SealedClassWithNestedAbstractClassWithNestedSealedClassWithGenericParameterGenericParameterConstraint
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
