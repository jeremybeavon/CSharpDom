namespace CSharpDom.TestTarget.Partial.Structs.NestedStaticPartialClasses.NestedStructs
{
    public struct StructWithNestedStaticPartialClassWithNestedStructWithGenericParameterEmptyConstructorConstraint
    {
        public static partial class Class
        {
            public struct NestedStruct<T>
                where T : new()
            {
            }
        }
    }
}
