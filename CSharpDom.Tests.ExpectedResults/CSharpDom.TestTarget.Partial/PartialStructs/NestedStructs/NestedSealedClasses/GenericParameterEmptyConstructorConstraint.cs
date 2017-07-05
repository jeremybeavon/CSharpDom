namespace CSharpDom.TestTarget.Partial.PartialStructs.NestedStructs.NestedSealedClasses
{
    public partial struct PartialStructWithWithNestedStructWithNestedSealedClassWithGenericParameterEmptyConstructorConstraint
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
