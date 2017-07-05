namespace CSharpDom.TestTarget.Partial.PartialStructs.NestedInterfaces
{
    public partial struct PartialStructWithWithNestedInterfaceWithGenericParameterInterfaceConstraint
    {
        public interface Interface<T>
            where T : IInterface
        {
        }
    }
}
