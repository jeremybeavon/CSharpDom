namespace CSharpDom.TestTarget.Partial.StaticClasses.NestedInterfaces
{
    public static class StaticClassWithNestedInterfaceWithGenericParameterClassConstraint
    {
        public interface Interface<T>
            where T : class
        {
        }
    }
}
