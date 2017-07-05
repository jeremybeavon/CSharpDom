namespace CSharpDom.TestTarget.Partial.StaticClasses.NestedPartialClasses.NestedAbstractClasses
{
    public static class StaticClassWithNestedPartialClassWithNestedAbstractPartialClassWithGenericParameterGenericParameterConstraint
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
