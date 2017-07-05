namespace CSharpDom.TestTarget.Partial.PartialStructs.NestedInterfaces
{
    public partial struct PartialStructWithWithNestedInterfaceWithGenericParameterEmptyConstructorConstraint
    {
        public interface Interface<T>
            where T : new()
        {
        }
    }
}
