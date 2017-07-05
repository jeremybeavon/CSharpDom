namespace CSharpDom.TestTarget.Partial.AbstractPartialClasses.NestedSealedClasses.NestedAbstractClasses
{
    public abstract partial class AbstractPartialClassWithNestedSealedClassWithNestedAbstractClassWithGenericParameterGenericParameterConstraint
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
