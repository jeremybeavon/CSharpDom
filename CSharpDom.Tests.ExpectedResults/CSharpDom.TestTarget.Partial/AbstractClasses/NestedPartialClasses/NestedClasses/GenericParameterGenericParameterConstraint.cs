namespace CSharpDom.TestTarget.Partial.AbstractClasses.NestedPartialClasses.NestedClasses
{
    public abstract class AbstractClassWithNestedPartialClassWithNestedPartialClassWithGenericParameterGenericParameterConstraint
    {
        public partial class Class
        {
            public class NestedClass<TKey, TValue>
                where TKey : TValue
            {
            }
        }
    }
}
