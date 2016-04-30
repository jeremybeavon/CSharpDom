namespace CSharpDom.TestTarget.SealedClasses.NestedSealedClasses
{
    public sealed class SealedClassWithNestedSealedClassWithGenericParameterEmptyConstructorConstraint
    {
        public sealed class Class<T>
            where T : new()
        {
        }
    }
}
