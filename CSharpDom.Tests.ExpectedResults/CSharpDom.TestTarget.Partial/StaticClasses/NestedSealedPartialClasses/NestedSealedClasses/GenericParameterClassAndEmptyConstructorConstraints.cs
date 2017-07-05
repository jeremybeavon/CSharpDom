namespace CSharpDom.TestTarget.Partial.StaticClasses.NestedSealedPartialClasses.NestedSealedClasses
{
    public static class StaticClassWithNestedSealedPartialClassWithNestedSealedPartialClassWithGenericParameterClassAndEmptyConstructorConstraints
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
