namespace CSharpDom.TestTarget.Partial.StaticPartialClasses.NestedSealedClasses
{
    public static partial class StaticPartialClassWithNestedSealedClassWithGenericParameterGenericParameterConstraint
    {
        public sealed class Class<TKey, TValue>
            where TKey : TValue
        {
        }
    }
}
