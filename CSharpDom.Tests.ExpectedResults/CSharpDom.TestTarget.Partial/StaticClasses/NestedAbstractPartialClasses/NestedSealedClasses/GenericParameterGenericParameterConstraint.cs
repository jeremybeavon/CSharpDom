namespace CSharpDom.TestTarget.Partial.StaticClasses.NestedAbstractPartialClasses.NestedSealedClasses
{
    public static class StaticClassWithNestedAbstractPartialClassWithNestedSealedPartialClassWithGenericParameterGenericParameterConstraint
    {
        public abstract partial class Class
        {
            public sealed class NestedClass<TKey, TValue>
                where TKey : TValue
            {
            }
        }
    }
}
