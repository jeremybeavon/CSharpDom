namespace CSharpDom.TestTarget.Partial.AbstractPartialClasses.NestedSealedClasses
{
    public abstract partial class AbstractPartialClassWithNestedSealedClassWithGenericParameterInterfaceConstraint
    {
        public sealed class Class<T>
            where T : IInterface
        {
        }
    }
}
