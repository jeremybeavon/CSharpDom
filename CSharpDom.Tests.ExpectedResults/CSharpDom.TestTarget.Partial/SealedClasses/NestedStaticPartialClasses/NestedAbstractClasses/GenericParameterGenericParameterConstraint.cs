namespace CSharpDom.TestTarget.Partial.SealedClasses.NestedStaticPartialClasses.NestedAbstractClasses
{
    public sealed class SealedClassWithNestedStaticPartialClassWithNestedAbstractPartialClassWithGenericParameterGenericParameterConstraint
    {
        public static partial class Class
        {
            public abstract class NestedClass<TKey, TValue>
                where TKey : TValue
            {
            }
        }
    }
}
