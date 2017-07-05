namespace CSharpDom.TestTarget.Partial.StaticPartialClasses.NestedSealedClasses.NestedStaticClasses
{
    public static partial class StaticPartialClassWithNestedSealedClassWithNestedStaticClassWithGenericParameterClassAndEmptyConstructorConstraints
    {
        public sealed class Class
        {
            public static class NestedClass<T>
                where T : class, new()
            {
            }
        }
    }
}
