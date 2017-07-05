namespace CSharpDom.TestTarget.Partial.PartialStructs.NestedSealedClasses.NestedStaticClasses
{
    public partial struct PartialStructWithWithNestedSealedClassWithNestedStaticClassWithGenericParameterEmptyConstructorConstraint
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
