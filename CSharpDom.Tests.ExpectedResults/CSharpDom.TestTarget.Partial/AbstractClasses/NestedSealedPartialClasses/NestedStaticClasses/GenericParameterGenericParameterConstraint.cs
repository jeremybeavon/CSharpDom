namespace CSharpDom.TestTarget.Partial.AbstractClasses.NestedSealedPartialClasses.NestedStaticClasses
{
    public abstract class AbstractClassWithNestedSealedPartialClassWithNestedStaticPartialClassWithGenericParameterGenericParameterConstraint
    {
        public sealed partial class Class
        {
            public static class NestedClass<TKey, TValue>
                where TKey : TValue
            {
            }
        }
    }
}
