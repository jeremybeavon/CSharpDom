namespace CSharpDom.TestTarget.Partial.PartialClasses.NestedInterfaces
{
    public partial class PartialClassWithNestedInterfaceWithGenericParameterBaseClassConstraint
    {
        public interface Interface<T>
            where T : BaseClass
        {
        }
    }
}
