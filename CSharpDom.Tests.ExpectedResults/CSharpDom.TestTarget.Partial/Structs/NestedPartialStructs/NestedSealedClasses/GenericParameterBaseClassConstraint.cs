namespace CSharpDom.TestTarget.Partial.Structs.NestedStructs.NestedSealedClasses
{
    public struct StructWithNestedStructWithNestedSealedPartialClassWithGenericParameterBaseClassConstraint
    {
        public struct Struct
        {
            public sealed class NestedClass<T>
                where T : BaseClass
            {
            }
        }
    }
}
