namespace CSharpDom.TestTarget.AbstractClasses.NestedStaticClasses.NestedInterfaces
{
    public abstract class AbstractClassWithNestedStaticClassWithNestedInterfaceWithGenericParameterClassAndEmptyConstructorConstraints
    {
        public static class Class
        {
            public interface Interface<T>
                where T : class, new()
            {
            }
        }
    }
}
