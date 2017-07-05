namespace CSharpDom.TestTarget.Partial.Structs.NestedStructs.NestedStructs
{
    public struct StructWithNestedStructWithNestedStructWithGenericParameterInterfaceConstraint
    {
        public struct Struct
        {
            public struct NestedStruct<T>
                where T : IInterface
            {
            }
        }
    }
}
