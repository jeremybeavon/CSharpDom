namespace CSharpDom.TestTarget.Partial.AbstractClasses.NestedPartialClasses.NestedStaticClasses
{
    public abstract class AbstractClassWithNestedPartialClassWithNestedStaticPartialClassWithGenericParameterGenericParameterConstraint
    {
        public partial class Class
        {
            public static class NestedClass<TKey, TValue>
                where TKey : TValue
            {
            }
        }
    }
}
