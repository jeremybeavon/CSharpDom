namespace CSharpDom.TestTarget.Partial.Structs.NestedStructs.NestedSealedClasses
{
    public struct StructWithNestedStructWithNestedSealedPartialClassWithGenericParameterInterfaceConstraint
    {
        public struct Struct
        {
            public sealed class NestedClass<T>
                where T : IInterface
            {
            }
        }
    }
}
