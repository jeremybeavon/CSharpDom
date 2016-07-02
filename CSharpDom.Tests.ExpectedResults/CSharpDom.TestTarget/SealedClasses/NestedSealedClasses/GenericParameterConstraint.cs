namespace CSharpDom.TestTarget.SealedClasses.NestedSealedClasses
{
    public sealed class SealedClassWithNestedSealedClassWithGenericParameterClassConstraint
    {
        public sealed class Class<T>
            where T : class
        {
        }
    }
}
