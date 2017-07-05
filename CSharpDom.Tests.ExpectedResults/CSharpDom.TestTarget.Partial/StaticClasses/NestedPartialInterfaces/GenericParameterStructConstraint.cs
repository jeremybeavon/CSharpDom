namespace CSharpDom.TestTarget.Partial.StaticClasses.NestedInterfaces
{
    public static class StaticClassWithNestedInterfaceWithGenericParameterStructConstraint
    {
        public interface Interface<T>
            where T : struct
        {
        }
    }
}
