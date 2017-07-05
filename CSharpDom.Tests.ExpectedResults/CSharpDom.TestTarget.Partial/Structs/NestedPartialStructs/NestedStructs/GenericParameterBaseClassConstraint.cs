namespace CSharpDom.TestTarget.Partial.Structs.NestedStructs.NestedStructs
{
    public struct StructWithNestedStructWithNestedStructWithGenericParameterBaseClassConstraint
    {
        public struct Struct
        {
            public struct NestedStruct<T>
                where T : BaseClass
            {
            }
        }
    }
}
