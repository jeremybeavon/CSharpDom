namespace CSharpDom.TestTarget.Structs.NestedStructs
{
    public struct StructWithNestedStructWithGenericParameterInterfaceConstraint
    {
        public struct Struct<T>
            where T : IInterface
        {
        }
    }
}
