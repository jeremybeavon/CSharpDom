namespace CSharpDom.TestTarget.Partial.PartialStructs.NestedInterfaces
{
    public partial struct PartialStructWithWithNestedInterfaceWithGenericParameterClassConstraint
    {
        public interface Interface<T>
            where T : class
        {
        }
    }
}
