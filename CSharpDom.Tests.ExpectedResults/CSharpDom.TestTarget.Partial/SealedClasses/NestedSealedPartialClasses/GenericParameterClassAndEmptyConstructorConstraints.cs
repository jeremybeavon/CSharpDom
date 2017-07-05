namespace CSharpDom.TestTarget.Partial.SealedClasses.NestedSealedClasses
{
    public sealed class SealedClassWithNestedSealedPartialClassWithGenericParameterClassAndEmptyConstructorConstraints
    {
        public sealed class Class<T>
            where T : class, new()
        {
        }
    }
}
