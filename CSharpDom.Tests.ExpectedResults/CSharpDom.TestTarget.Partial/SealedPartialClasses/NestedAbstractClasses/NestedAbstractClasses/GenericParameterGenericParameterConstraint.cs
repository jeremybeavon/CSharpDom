namespace CSharpDom.TestTarget.Partial.SealedPartialClasses.NestedAbstractClasses.NestedAbstractClasses
{
    public sealed partial class SealedPartialClassWithNestedAbstractClassWithNestedAbstractClassWithGenericParameterGenericParameterConstraint
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
