namespace CSharpDom.TestTarget.AbstractClasses.NestedAbstractClasses.NestedSealedClasses
{
    public abstract class AbstractClassWithNestedAbstractClassWithNestedSealedClassWithGenericParameterGenericParameterConstraint
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
