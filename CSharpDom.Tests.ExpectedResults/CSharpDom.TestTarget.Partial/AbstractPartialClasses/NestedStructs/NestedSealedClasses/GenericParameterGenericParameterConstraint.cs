namespace CSharpDom.TestTarget.Partial.AbstractPartialClasses.NestedStructs.NestedSealedClasses
{
    public abstract partial class AbstractPartialClassWithNestedStructWithNestedSealedClassWithGenericParameterGenericParameterConstraint
    {
        public struct Struct
        {
            public sealed class NestedClass<TKey, TValue>
                where TKey : TValue
            {
            }
        }
    }
}
