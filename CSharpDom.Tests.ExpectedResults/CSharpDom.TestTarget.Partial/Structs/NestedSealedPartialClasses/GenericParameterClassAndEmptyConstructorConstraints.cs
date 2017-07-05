namespace CSharpDom.TestTarget.Partial.Structs.NestedSealedClasses
{
    public struct StructWithNestedSealedPartialClassWithGenericParameterClassAndEmptyConstructorConstraints
    {
        public sealed class Class<T>
            where T : class, new()
        {
        }
    }
}
