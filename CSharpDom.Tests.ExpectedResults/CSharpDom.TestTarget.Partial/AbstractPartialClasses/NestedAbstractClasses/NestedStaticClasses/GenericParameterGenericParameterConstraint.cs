namespace CSharpDom.TestTarget.Partial.AbstractPartialClasses.NestedAbstractClasses.NestedStaticClasses
{
    public abstract partial class AbstractPartialClassWithNestedAbstractClassWithNestedStaticClassWithGenericParameterGenericParameterConstraint
    {
        public abstract class Class
        {
            public static class NestedClass<TKey, TValue>
                where TKey : TValue
            {
            }
        }
    }
}
