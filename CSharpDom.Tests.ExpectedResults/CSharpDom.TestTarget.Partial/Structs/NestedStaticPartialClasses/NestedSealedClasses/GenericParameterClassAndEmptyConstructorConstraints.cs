namespace CSharpDom.TestTarget.Partial.Structs.NestedStaticPartialClasses.NestedSealedClasses
{
    public struct StructWithNestedStaticPartialClassWithNestedSealedPartialClassWithGenericParameterClassAndEmptyConstructorConstraints
    {
        public static partial class Class
        {
            public sealed class NestedClass<T>
                where T : class, new()
            {
            }
        }
    }
}
