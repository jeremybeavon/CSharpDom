namespace CSharpDom.TestTarget.Partial.SealedClasses.NestedAbstractClasses
{
    public sealed class SealedClassWithNestedAbstractPartialClassWithGenericParameterInterfaceConstraint
    {
        public abstract class Class<T>
            where T : IInterface
        {
        }
    }
}
