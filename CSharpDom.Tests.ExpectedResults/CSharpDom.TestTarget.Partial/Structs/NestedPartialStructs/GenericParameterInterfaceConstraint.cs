namespace CSharpDom.TestTarget.Partial.Structs.NestedStructs
{
    public struct StructWithNestedStructWithGenericParameterInterfaceConstraint
    {
        public struct Struct<T>
            where T : IInterface
        {
        }
    }
}
