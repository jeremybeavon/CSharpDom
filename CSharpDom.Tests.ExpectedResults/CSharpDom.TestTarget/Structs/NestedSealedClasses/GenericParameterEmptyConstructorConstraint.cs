namespace CSharpDom.TestTarget.Structs.NestedSealedClasses
{
    public struct StructWithNestedSealedClassWithGenericParameterEmptyConstructorConstraint
    {
        public sealed class Class<T>
            where T : new()
        {
        }
    }
}
