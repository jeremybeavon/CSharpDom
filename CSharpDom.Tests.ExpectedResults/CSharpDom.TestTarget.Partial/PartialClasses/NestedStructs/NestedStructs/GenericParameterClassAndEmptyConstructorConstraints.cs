namespace CSharpDom.TestTarget.Partial.PartialClasses.NestedStructs.NestedStructs
{
    public partial class PartialClassWithNestedStructWithNestedStructWithGenericParameterClassAndEmptyConstructorConstraints
    {
        public struct Struct
        {
            public struct NestedStruct<T>
                where T : class, new()
            {
            }
        }
    }
}
