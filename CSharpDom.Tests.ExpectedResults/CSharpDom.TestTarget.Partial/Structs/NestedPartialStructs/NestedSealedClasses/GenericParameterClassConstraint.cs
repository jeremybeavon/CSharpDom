namespace CSharpDom.TestTarget.Partial.Structs.NestedStructs.NestedSealedClasses
{
    public struct StructWithNestedStructWithNestedSealedPartialClassWithGenericParameterClassConstraint
    {
        public struct Struct
        {
            public sealed class NestedClass<T>
                where T : class
            {
            }
        }
    }
}
