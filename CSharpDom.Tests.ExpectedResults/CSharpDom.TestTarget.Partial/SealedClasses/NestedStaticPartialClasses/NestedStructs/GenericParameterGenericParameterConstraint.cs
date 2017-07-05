namespace CSharpDom.TestTarget.Partial.SealedClasses.NestedStaticPartialClasses.NestedStructs
{
    public sealed class SealedClassWithNestedStaticPartialClassWithNestedStructWithGenericParameterGenericParameterConstraint
    {
        public static partial class Class
        {
            public struct NestedStruct<TKey, TValue>
                where TKey : TValue
            {
            }
        }
    }
}
