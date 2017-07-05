namespace CSharpDom.TestTarget.Partial.SealedClasses.NestedStructs.NestedAbstractClasses
{
    public sealed class SealedClassWithNestedStructWithNestedAbstractPartialClassWithGenericParameterGenericParameterConstraint
    {
        public struct Struct
        {
            public abstract class NestedClass<TKey, TValue>
                where TKey : TValue
            {
            }
        }
    }
}
