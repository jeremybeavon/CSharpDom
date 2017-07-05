namespace CSharpDom.TestTarget.Partial.AbstractClasses.NestedSealedPartialClasses.NestedClasses
{
    public abstract class AbstractClassWithNestedSealedPartialClassWithNestedPartialClassWithGenericParameterGenericParameterConstraint
    {
        public sealed partial class Class
        {
            public class NestedClass<TKey, TValue>
                where TKey : TValue
            {
            }
        }
    }
}
