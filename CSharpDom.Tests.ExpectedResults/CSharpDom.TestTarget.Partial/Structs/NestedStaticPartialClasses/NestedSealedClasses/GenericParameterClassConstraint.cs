namespace CSharpDom.TestTarget.Partial.Structs.NestedStaticPartialClasses.NestedSealedClasses
{
    public struct StructWithNestedStaticPartialClassWithNestedSealedPartialClassWithGenericParameterClassConstraint
    {
        public static partial class Class
        {
            public sealed class NestedClass<T>
                where T : class
            {
            }
        }
    }
}
