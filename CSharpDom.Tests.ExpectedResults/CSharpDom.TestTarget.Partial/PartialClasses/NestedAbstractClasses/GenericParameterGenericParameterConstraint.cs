namespace CSharpDom.TestTarget.Partial.PartialClasses.NestedAbstractClasses
{
    public partial class PartialClassWithNestedAbstractClassWithGenericParameterGenericParameterConstraint
    {
        public abstract class Class<TKey, TValue>
            where TKey : TValue
        {
        }
    }
}
