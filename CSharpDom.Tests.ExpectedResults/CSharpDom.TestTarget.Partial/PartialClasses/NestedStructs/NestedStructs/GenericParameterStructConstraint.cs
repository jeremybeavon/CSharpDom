namespace CSharpDom.TestTarget.Partial.PartialClasses.NestedStructs.NestedStructs
{
    public partial class PartialClassWithNestedStructWithNestedStructWithGenericParameterStructConstraint
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
