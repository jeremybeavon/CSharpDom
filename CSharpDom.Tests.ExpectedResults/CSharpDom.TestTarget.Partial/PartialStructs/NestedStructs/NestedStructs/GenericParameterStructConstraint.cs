namespace CSharpDom.TestTarget.Partial.PartialStructs.NestedStructs.NestedStructs
{
    public partial struct PartialStructWithWithNestedStructWithNestedStructWithGenericParameterStructConstraint
    {
        public struct Struct
        {
            public struct NestedStruct<T>
                where T : struct
            {
            }
        }
    }
}
