namespace CSharpDom.TestTarget.Partial.PartialClasses.NestedSealedClasses.NestedStaticClasses
{
    public partial class PartialClassWithNestedSealedClassWithNestedStaticClassWithGenericParameterEmptyConstructorConstraint
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
