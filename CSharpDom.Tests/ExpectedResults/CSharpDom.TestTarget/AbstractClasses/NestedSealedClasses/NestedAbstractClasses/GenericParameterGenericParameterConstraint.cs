namespace CSharpDom.TestTarget.AbstractClasses.NestedSealedClasses.NestedAbstractClasses
{
    public abstract class AbstractClassWithNestedSealedClassWithNestedAbstractClassWithGenericParameterGenericParameterConstraint
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
