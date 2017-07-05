namespace CSharpDom.TestTarget.Partial.StaticPartialClasses.NestedSealedClasses.NestedStructs
{
    public static partial class StaticPartialClassWithNestedSealedClassWithNestedStructWithGenericParameterGenericParameterConstraint
    {
        public sealed class Class
        {
            public struct NestedStruct<TKey, TValue>
                where TKey : TValue
            {
            }
        }
    }
}
