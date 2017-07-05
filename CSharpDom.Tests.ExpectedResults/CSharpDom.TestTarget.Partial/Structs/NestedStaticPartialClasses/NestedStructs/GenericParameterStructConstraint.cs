namespace CSharpDom.TestTarget.Partial.Structs.NestedStaticPartialClasses.NestedStructs
{
    public struct StructWithNestedStaticPartialClassWithNestedStructWithGenericParameterStructConstraint
    {
        public static partial class Class
        {
            public struct NestedStruct<T>
                where T : struct
            {
            }
        }
    }
}
