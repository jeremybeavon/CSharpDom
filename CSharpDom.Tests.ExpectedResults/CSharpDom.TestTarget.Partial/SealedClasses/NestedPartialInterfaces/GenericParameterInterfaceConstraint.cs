namespace CSharpDom.TestTarget.Partial.SealedClasses.NestedInterfaces
{
    public sealed class SealedClassWithNestedInterfaceWithGenericParameterInterfaceConstraint
    {
        public interface Interface<T>
            where T : IInterface
        {
        }
    }
}
