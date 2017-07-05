namespace CSharpDom.TestTarget.Partial.SealedPartialClasses.NestedSealedClasses
{
    public sealed partial class SealedPartialClassWithNestedSealedClassWithGenericParameterEmptyConstructorConstraint
    {
        public sealed class Class<T>
            where T : new()
        {
        }
    }
}
