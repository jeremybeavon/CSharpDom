namespace CSharpDom.TestTarget.Structs.NestedStructs.NestedSealedClasses
{
    public struct StructWithNestedStructWithNestedSealedClassWithGenericParameterEmptyConstructorConstraint
    {
        public struct Struct
        {
            public sealed class NestedClass<T>
                where T : new()
            {
            }
        }
    }
}
