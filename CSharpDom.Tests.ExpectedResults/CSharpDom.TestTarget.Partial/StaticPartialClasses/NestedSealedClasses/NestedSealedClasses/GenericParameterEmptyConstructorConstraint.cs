namespace CSharpDom.TestTarget.Partial.StaticPartialClasses.NestedSealedClasses.NestedSealedClasses
{
    public static partial class StaticPartialClassWithNestedSealedClassWithNestedSealedClassWithGenericParameterEmptyConstructorConstraint
    {
        public sealed class Class
        {
            public sealed class NestedClass<T>
                where T : new()
            {
            }
        }
    }
}
