namespace CSharpDom.TestTarget.Partial.PartialStructs.NestedSealedClasses.NestedAbstractClasses
{
    public partial struct PartialStructWithWithNestedSealedClassWithNestedAbstractClassWithGenericParameterGenericParameterConstraint
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
