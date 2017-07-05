namespace CSharpDom.TestTarget.Partial.StaticClasses.NestedInterfaces
{
    public static class StaticClassWithNestedInterfaceWithGenericParameterBaseClassConstraint
    {
        public interface Interface<T>
            where T : BaseClass
        {
        }
    }
}
