namespace CSharpDom.TestTarget.Partial.PartialClasses.NestedStaticClasses.NestedSealedClasses
{
    public partial class PartialClassWithNestedStaticClassWithNestedSealedClassWithGenericParameterEmptyConstructorConstraint
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
