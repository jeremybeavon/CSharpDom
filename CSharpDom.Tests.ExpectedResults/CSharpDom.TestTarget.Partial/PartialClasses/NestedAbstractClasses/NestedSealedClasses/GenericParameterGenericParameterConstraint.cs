namespace CSharpDom.TestTarget.Partial.PartialClasses.NestedAbstractClasses.NestedSealedClasses
{
    public partial class PartialClassWithNestedAbstractClassWithNestedSealedClassWithGenericParameterGenericParameterConstraint
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
