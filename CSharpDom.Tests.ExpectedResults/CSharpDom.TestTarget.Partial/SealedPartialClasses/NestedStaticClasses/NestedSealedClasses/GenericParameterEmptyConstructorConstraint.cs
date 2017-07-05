namespace CSharpDom.TestTarget.Partial.SealedPartialClasses.NestedStaticClasses.NestedSealedClasses
{
    public sealed partial class SealedPartialClassWithNestedStaticClassWithNestedSealedClassWithGenericParameterEmptyConstructorConstraint
    {
        public static class Class
        {
            public sealed class NestedClass<T>
                where T : new()
            {
            }
        }
    }
}
