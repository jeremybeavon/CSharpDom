namespace CSharpDom.TestTarget.Partial.Structs.NestedStaticPartialClasses.NestedStructs
{
    public struct StructWithNestedStaticPartialClassWithNestedStructWithGenericParameterClassConstraint
    {
        public static partial class Class
        {
            public struct NestedStruct<T>
                where T : class
            {
            }
        }
    }
}
