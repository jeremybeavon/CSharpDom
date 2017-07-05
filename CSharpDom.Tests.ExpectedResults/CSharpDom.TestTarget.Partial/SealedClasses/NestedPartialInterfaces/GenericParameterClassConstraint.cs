namespace CSharpDom.TestTarget.Partial.SealedClasses.NestedInterfaces
{
    public sealed class SealedClassWithNestedInterfaceWithGenericParameterClassConstraint
    {
        public interface Interface<T>
            where T : class
        {
        }
    }
}
