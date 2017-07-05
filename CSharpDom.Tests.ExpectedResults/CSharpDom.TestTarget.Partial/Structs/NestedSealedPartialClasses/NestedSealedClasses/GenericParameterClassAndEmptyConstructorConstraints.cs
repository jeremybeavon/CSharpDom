namespace CSharpDom.TestTarget.Partial.Structs.NestedSealedPartialClasses.NestedSealedClasses
{
    public struct StructWithNestedSealedPartialClassWithNestedSealedPartialClassWithGenericParameterClassAndEmptyConstructorConstraints
    {
        public sealed partial class Class
        {
            public sealed class NestedClass<T>
                where T : class, new()
            {
            }
        }
    }
}
