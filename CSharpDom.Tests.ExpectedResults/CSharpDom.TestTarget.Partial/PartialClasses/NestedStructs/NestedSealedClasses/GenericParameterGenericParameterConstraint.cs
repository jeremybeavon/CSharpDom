namespace CSharpDom.TestTarget.Partial.PartialClasses.NestedStructs.NestedSealedClasses
{
    public partial class PartialClassWithNestedStructWithNestedSealedClassWithGenericParameterGenericParameterConstraint
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
