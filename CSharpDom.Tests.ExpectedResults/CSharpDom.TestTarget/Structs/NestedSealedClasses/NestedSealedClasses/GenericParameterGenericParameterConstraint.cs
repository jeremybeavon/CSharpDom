namespace CSharpDom.TestTarget.Structs.NestedSealedClasses.NestedSealedClasses
{
    public struct StructWithNestedSealedClassWithNestedSealedClassWithGenericParameterGenericParameterConstraint
    {
        public sealed class Class
        {
            public sealed class NestedClass<TKey, TValue>
                where TKey : TValue
            {
            }
        }
    }
}
