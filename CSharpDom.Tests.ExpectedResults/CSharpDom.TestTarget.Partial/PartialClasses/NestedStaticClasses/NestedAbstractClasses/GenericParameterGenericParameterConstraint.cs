namespace CSharpDom.TestTarget.Partial.PartialClasses.NestedStaticClasses.NestedAbstractClasses
{
    public partial class PartialClassWithNestedStaticClassWithNestedAbstractClassWithGenericParameterGenericParameterConstraint
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
