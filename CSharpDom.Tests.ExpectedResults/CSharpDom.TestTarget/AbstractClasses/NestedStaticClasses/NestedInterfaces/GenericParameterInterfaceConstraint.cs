namespace CSharpDom.TestTarget.AbstractClasses.NestedStaticClasses.NestedInterfaces
{
    public abstract class AbstractClassWithNestedStaticClassWithNestedInterfaceWithGenericParameterInterfaceConstraint
    {
        public static class Class
        {
            public interface Interface<T>
                where T : IInterface
            {
            }
        }
    }
}
