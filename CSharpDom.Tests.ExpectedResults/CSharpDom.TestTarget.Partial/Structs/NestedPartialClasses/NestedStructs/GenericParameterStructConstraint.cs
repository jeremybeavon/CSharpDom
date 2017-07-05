namespace CSharpDom.TestTarget.Partial.Structs.NestedPartialClasses.NestedStructs
{
    public struct StructWithNestedPartialClassWithNestedStructWithGenericParameterStructConstraint
    {
        public partial class Class
        {
            public struct NestedStruct<T>
                where T : struct
            {
            }
        }
    }
}
