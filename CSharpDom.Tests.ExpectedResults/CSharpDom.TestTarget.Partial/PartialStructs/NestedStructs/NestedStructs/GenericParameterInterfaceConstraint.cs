namespace CSharpDom.TestTarget.Partial.PartialStructs.NestedStructs.NestedStructs
{
    public partial struct PartialStructWithWithNestedStructWithNestedStructWithGenericParameterInterfaceConstraint
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
