namespace CSharpDom.TestTarget.Partial.Structs.NestedPartialClasses.NestedStructs
{
    public struct StructWithNestedPartialClassWithNestedStructWithGenericParameterBaseClassConstraint
    {
        public partial class Class
        {
            public struct NestedStruct<T>
                where T : BaseClass
            {
            }
        }
    }
}
