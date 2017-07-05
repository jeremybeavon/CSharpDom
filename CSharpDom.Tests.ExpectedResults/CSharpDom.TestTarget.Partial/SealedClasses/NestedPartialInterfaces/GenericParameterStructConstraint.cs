namespace CSharpDom.TestTarget.Partial.SealedClasses.NestedInterfaces
{
    public sealed class SealedClassWithNestedInterfaceWithGenericParameterStructConstraint
    {
        public interface Interface<T>
            where T : struct
        {
        }
    }
}
