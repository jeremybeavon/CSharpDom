namespace CSharpDom.TestTarget.AbstractClasses.NestedStaticClasses.NestedInterfaces
{
    public abstract class AbstractClassWithNestedStaticClassWithNestedInterfaceWithGenericParameterClassAndInterfaceAndEmptyConstructorConstraints
    {
        public static class Class
        {
            public interface Interface<T>
                where T : class, IInterface, new()
            {
            }
        }
    }
}
