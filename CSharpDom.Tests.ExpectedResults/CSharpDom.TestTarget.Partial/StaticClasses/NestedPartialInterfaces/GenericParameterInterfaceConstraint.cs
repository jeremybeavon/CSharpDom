namespace CSharpDom.TestTarget.Partial.StaticClasses.NestedInterfaces
{
    public static class StaticClassWithNestedInterfaceWithGenericParameterInterfaceConstraint
    {
        public interface Interface<T>
            where T : IInterface
        {
        }
    }
}
