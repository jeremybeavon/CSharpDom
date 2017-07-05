namespace CSharpDom.TestTarget.Partial.AbstractPartialClasses.NestedSealedClasses.NestedStaticClasses
{
    public abstract partial class AbstractPartialClassWithNestedSealedClassWithNestedStaticClassWithGenericParameterGenericParameterConstraint
    {
        public sealed class Class
        {
            public static class NestedClass<TKey, TValue>
                where TKey : TValue
            {
            }
        }
    }
}
