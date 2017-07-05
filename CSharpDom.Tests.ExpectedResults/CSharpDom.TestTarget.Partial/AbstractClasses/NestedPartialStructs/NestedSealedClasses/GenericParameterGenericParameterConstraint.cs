namespace CSharpDom.TestTarget.Partial.AbstractClasses.NestedStructs.NestedSealedClasses
{
    public abstract class AbstractClassWithNestedStructWithNestedSealedPartialClassWithGenericParameterGenericParameterConstraint
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
