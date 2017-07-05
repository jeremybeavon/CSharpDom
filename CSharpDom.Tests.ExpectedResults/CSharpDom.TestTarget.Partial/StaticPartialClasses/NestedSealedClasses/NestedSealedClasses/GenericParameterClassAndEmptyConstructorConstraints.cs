namespace CSharpDom.TestTarget.Partial.StaticPartialClasses.NestedSealedClasses.NestedSealedClasses
{
    public static partial class StaticPartialClassWithNestedSealedClassWithNestedSealedClassWithGenericParameterClassAndEmptyConstructorConstraints
    {
        public sealed class Class
        {
            public sealed class NestedClass<T>
                where T : class, new()
            {
            }
        }
    }
}
