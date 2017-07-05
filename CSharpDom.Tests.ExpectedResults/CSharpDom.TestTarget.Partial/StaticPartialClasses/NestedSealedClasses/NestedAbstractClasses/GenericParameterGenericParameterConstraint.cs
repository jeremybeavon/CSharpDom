namespace CSharpDom.TestTarget.Partial.StaticPartialClasses.NestedSealedClasses.NestedAbstractClasses
{
    public static partial class StaticPartialClassWithNestedSealedClassWithNestedAbstractClassWithGenericParameterGenericParameterConstraint
    {
        public sealed class Class
        {
            public abstract class NestedClass<TKey, TValue>
                where TKey : TValue
            {
            }
        }
    }
}
