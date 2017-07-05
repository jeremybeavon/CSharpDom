namespace CSharpDom.TestTarget.Partial.StaticPartialClasses.NestedSealedClasses.NestedStaticClasses
{
    public static partial class StaticPartialClassWithNestedSealedClassWithNestedStaticClassWithGenericParameterEmptyConstructorConstraint
    {
        public sealed class Class
        {
            public static class NestedClass<T>
                where T : new()
            {
            }
        }
    }
}
