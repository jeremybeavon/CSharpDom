namespace CSharpDom.TestTarget.Partial.SealedPartialClasses.NestedStaticClasses.NestedAbstractClasses
{
    public sealed partial class SealedPartialClassWithNestedStaticClassWithNestedAbstractClassWithGenericParameterGenericParameterConstraint
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
