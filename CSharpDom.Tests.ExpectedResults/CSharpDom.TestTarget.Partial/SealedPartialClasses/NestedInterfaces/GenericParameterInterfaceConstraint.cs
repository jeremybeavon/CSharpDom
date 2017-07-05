namespace CSharpDom.TestTarget.Partial.SealedPartialClasses.NestedInterfaces
{
    public sealed partial class SealedPartialClassWithNestedInterfaceWithGenericParameterInterfaceConstraint
    {
        public interface Interface<T>
            where T : IInterface
        {
        }
    }
}
