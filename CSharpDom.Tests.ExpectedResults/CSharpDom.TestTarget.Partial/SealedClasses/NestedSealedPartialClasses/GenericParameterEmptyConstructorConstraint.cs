namespace CSharpDom.TestTarget.Partial.SealedClasses.NestedSealedClasses
{
    public sealed class SealedClassWithNestedSealedPartialClassWithGenericParameterEmptyConstructorConstraint
    {
        public sealed class Class<T>
            where T : new()
        {
        }
    }
}
