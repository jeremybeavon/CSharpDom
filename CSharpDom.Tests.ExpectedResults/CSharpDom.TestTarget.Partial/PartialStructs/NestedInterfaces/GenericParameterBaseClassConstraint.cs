namespace CSharpDom.TestTarget.Partial.PartialStructs.NestedInterfaces
{
    public partial struct PartialStructWithWithNestedInterfaceWithGenericParameterBaseClassConstraint
    {
        public interface Interface<T>
            where T : BaseClass
        {
        }
    }
}
