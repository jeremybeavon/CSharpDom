namespace CSharpDom.TestTarget.Partial.SealedClasses.NestedInterfaces
{
    public sealed class SealedClassWithNestedInterfaceWithGenericParameterBaseClassConstraint
    {
        public interface Interface<T>
            where T : BaseClass
        {
        }
    }
}
