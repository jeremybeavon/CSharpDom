namespace CSharpDom.TestTarget.Partial.Structs.NestedStructs.NestedClasses
{
    public struct StructWithNestedStructWithNestedPartialClassWithGenericParameterClassConstraint
    {
        public struct Struct
        {
            public class NestedClass<T>
                where T : class
            {
            }
        }
    }
}
