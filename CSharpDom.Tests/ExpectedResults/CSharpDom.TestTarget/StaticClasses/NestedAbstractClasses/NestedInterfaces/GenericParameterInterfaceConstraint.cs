namespace CSharpDom.TestTarget.StaticClasses.NestedAbstractClasses.NestedInterfaces
{
    public static class StaticClassWithNestedAbstractClassWithNestedInterfaceWithGenericParameterInterfaceConstraint
    {
        public abstract class Class
        {
            public interface Interface<T>
                where T : IInterface
            {
            }
        }
    }
}
