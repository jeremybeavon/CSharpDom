namespace CSharpDom.TestTarget.SealedClasses.NestedAbstractClasses.NestedAbstractClasses
{
    public sealed class SealedClassWithNestedAbstractClassWithNestedAbstractClassWithGenericParameterGenericParameterConstraint
    {
        public abstract class Class
        {
            public abstract class NestedClass<TKey, TValue>
                where TKey : TValue
            {
            }
        }
    }
}
