namespace CSharpDom.TestTarget.Partial.PartialStructs.NestedSealedClasses.NestedStructs
{
    public partial struct PartialStructWithWithNestedSealedClassWithNestedStructWithGenericParameterGenericParameterConstraint
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
