namespace CSharpDom.TestTarget.Partial.Structs.NestedPartialClasses.NestedStructs
{
    public struct StructWithNestedPartialClassWithNestedStructWithGenericParameterEmptyConstructorConstraint
    {
        public partial class Class
        {
            public struct NestedStruct<T>
                where T : new()
            {
            }
        }
    }
}
