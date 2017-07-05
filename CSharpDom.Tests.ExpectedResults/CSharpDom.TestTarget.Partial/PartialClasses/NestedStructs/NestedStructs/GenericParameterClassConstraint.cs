namespace CSharpDom.TestTarget.Partial.PartialClasses.NestedStructs.NestedStructs
{
    public partial class PartialClassWithNestedStructWithNestedStructWithGenericParameterClassConstraint
    {
        public struct Struct
        {
            public struct NestedStruct<T>
                where T : class
            {
            }
        }
    }
}
