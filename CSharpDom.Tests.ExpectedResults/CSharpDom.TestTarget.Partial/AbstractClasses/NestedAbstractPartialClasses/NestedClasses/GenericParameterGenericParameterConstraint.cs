namespace CSharpDom.TestTarget.Partial.AbstractClasses.NestedAbstractPartialClasses.NestedClasses
{
    public abstract class AbstractClassWithNestedAbstractPartialClassWithNestedPartialClassWithGenericParameterGenericParameterConstraint
    {
        public abstract partial class Class
        {
            public class NestedClass<TKey, TValue>
                where TKey : TValue
            {
            }
        }
    }
}
