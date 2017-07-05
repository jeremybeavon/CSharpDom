namespace CSharpDom.TestTarget.Partial.StaticPartialClasses.NestedAbstractClasses.NestedSealedClasses
{
    public static partial class StaticPartialClassWithNestedAbstractClassWithNestedSealedClassWithGenericParameterGenericParameterConstraint
    {
        public abstract class Class
        {
            public sealed class NestedClass<TKey, TValue>
                where TKey : TValue
            {
            }
        }
    }
}
