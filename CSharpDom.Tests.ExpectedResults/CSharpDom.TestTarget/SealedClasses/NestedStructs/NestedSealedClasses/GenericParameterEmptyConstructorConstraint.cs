namespace CSharpDom.TestTarget.SealedClasses.NestedStructs.NestedSealedClasses
{
    public sealed class SealedClassWithNestedStructWithNestedSealedClassWithGenericParameterEmptyConstructorConstraint
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
