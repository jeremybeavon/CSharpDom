namespace CSharpDom.TestTarget.Partial.SealedClasses.NestedPartialClasses.NestedAbstractClasses
{
    public sealed class SealedClassWithNestedPartialClassWithNestedAbstractPartialClassWithGenericParameterGenericParameterConstraint
    {
        public partial class Class
        {
            public abstract class NestedClass<TKey, TValue>
                where TKey : TValue
            {
            }
        }
    }
}
