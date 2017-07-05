namespace CSharpDom.TestTarget.Partial.PartialStructs.NestedSealedClasses.NestedSealedClasses
{
    public partial struct PartialStructWithWithNestedSealedClassWithNestedSealedClassWithGenericParameterClassAndEmptyConstructorConstraints
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
