namespace CSharpDom.TestTarget.Partial.SealedClasses.NestedSealedPartialClasses.NestedStaticClasses
{
    public sealed class SealedClassWithNestedSealedPartialClassWithNestedStaticPartialClassWithGenericParameterEmptyConstructorConstraint
    {
        public sealed partial class Class
        {
            public static class NestedClass<T>
                where T : new()
            {
            }
        }
    }
}
