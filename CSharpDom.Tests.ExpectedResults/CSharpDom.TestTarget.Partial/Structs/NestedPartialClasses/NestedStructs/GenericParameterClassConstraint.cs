namespace CSharpDom.TestTarget.Partial.Structs.NestedPartialClasses.NestedStructs
{
    public struct StructWithNestedPartialClassWithNestedStructWithGenericParameterClassConstraint
    {
        public partial class Class
        {
            public struct NestedStruct<T>
                where T : class
            {
            }
        }
    }
}
