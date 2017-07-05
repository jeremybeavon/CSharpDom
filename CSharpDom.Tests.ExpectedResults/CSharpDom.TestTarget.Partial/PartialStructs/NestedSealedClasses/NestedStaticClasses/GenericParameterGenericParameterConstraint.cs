namespace CSharpDom.TestTarget.Partial.PartialStructs.NestedSealedClasses.NestedStaticClasses
{
    public partial struct PartialStructWithWithNestedSealedClassWithNestedStaticClassWithGenericParameterGenericParameterConstraint
    {
        public sealed class Class
        {
            public static class NestedClass<TKey, TValue>
                where TKey : TValue
            {
            }
        }
    }
}
