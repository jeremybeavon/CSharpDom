namespace CSharpDom.TestTarget.Partial.PartialStructs.NestedStaticClasses.NestedSealedClasses
{
    public partial struct PartialStructWithNestedStaticClassWithNestedSealedClassWithGenericParameterClassConstraint
    {
        public static class Class
        {
            public sealed class NestedClass<T>
                where T : class
            {
            }
        }
    }
}
