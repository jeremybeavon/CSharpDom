namespace CSharpDom.TestTarget.Partial.StaticClasses.NestedSealedPartialClasses.NestedSealedClasses
{
    public static class StaticClassWithNestedSealedPartialClassWithNestedSealedPartialClassWithGenericParameterEmptyConstructorConstraint
    {
        public sealed partial class Class
        {
            public sealed class NestedClass<T>
                where T : new()
            {
            }
        }
    }
}
