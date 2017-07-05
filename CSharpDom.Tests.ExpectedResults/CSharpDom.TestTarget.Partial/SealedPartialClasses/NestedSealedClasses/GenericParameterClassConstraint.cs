namespace CSharpDom.TestTarget.Partial.SealedPartialClasses.NestedSealedClasses
{
    public sealed partial class SealedPartialClassWithNestedSealedClassWithGenericParameterClassConstraint
    {
        public sealed class Class<T>
            where T : class
        {
        }
    }
}
