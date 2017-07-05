namespace CSharpDom.TestTarget.Partial.Structs.NestedStaticPartialClasses.NestedSealedClasses
{
    public struct StructWithNestedStaticPartialClassWithNestedSealedPartialClassWithGenericParameterStructConstraint
    {
        public static partial class Class
        {
            public sealed class NestedClass<T>
                where T : struct
            {
            }
        }
    }
}
