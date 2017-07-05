namespace CSharpDom.TestTarget.Partial.StaticClasses.NestedAbstractPartialClasses.NestedAbstractClasses
{
    public static class StaticClassWithNestedAbstractPartialClassWithNestedAbstractPartialClassWithGenericParameterGenericParameterConstraint
    {
        public abstract partial class Class
        {
            public abstract class NestedClass<TKey, TValue>
                where TKey : TValue
            {
            }
        }
    }
}
