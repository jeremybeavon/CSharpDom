namespace CSharpDom.TestTarget.Partial.AbstractPartialClasses.NestedStaticClasses.NestedAbstractClasses
{
    public abstract partial class AbstractPartialClassWithNestedStaticClassWithNestedAbstractClassWithGenericParameterGenericParameterConstraint
    {
        public static class Class
        {
            public abstract class NestedClass<TKey, TValue>
                where TKey : TValue
            {
            }
        }
    }
}
