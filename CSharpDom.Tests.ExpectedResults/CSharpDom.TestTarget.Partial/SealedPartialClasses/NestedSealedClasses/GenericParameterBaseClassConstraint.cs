namespace CSharpDom.TestTarget.Partial.SealedPartialClasses.NestedSealedClasses
{
    public sealed partial class SealedPartialClassWithNestedSealedClassWithGenericParameterBaseClassConstraint
    {
        public sealed class Class<T>
            where T : BaseClass
        {
        }
    }
}
