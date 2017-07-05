namespace CSharpDom.TestTarget.Partial.PartialClasses.NestedStructs.NestedStaticClasses
{
    public partial class PartialClassWithNestedStructWithNestedStaticClassWithGenericParameterEmptyConstructorConstraint
    {
        public struct Struct
        {
            public static class NestedClass<T>
                where T : new()
            {
            }
        }
    }
}
