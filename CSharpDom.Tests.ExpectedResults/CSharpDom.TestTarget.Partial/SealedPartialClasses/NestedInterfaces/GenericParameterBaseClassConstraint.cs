namespace CSharpDom.TestTarget.Partial.SealedPartialClasses.NestedInterfaces
{
    public sealed partial class SealedPartialClassWithNestedInterfaceWithGenericParameterBaseClassConstraint
    {
        public interface Interface<T>
            where T : BaseClass
        {
        }
    }
}
