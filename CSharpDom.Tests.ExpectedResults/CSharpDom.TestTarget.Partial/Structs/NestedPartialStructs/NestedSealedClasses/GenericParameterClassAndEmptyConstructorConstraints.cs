namespace CSharpDom.TestTarget.Partial.Structs.NestedStructs.NestedSealedClasses
{
    public struct StructWithNestedStructWithNestedSealedPartialClassWithGenericParameterClassAndEmptyConstructorConstraints
    {
        public struct Struct
        {
            public sealed class NestedClass<T>
                where T : class, new()
            {
            }
        }
    }
}
