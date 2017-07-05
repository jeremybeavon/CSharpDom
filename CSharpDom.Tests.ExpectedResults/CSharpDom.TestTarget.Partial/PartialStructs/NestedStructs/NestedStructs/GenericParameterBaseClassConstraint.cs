namespace CSharpDom.TestTarget.Partial.PartialStructs.NestedStructs.NestedStructs
{
    public partial struct PartialStructWithWithNestedStructWithNestedStructWithGenericParameterBaseClassConstraint
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
