namespace CSharpDom.TestTarget.Partial.SealedClasses.NestedStaticPartialClasses.Methods
{
    public sealed class SealedClassWithNestedStaticPartialClassWithMethodWithGenericParameterGenericParameterConstraint
    {
        public static partial class Class
        {
            public static Dictionary<TKey, TValue> Method<TKey, TValue>()
                where TValue : TKey
            {
                return default(Dictionary<TKey, TValue>);
            }
        }
    }
}
