namespace CSharpDom.TestTarget.Partial.AbstractClasses.NestedPartialClasses.NestedSealedClasses
{
    public abstract class AbstractClassWithNestedPartialClassWithNestedSealedPartialClassWithGenericParameterGenericParameterConstraint
    {
        public partial class Class
        {
            public sealed class NestedClass<TKey, TValue>
                where TKey : TValue
            {
            }
        }
    }
}
