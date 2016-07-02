namespace CSharpDom.TestTarget.StaticClasses.NestedClasses.NestedInterfaces
{
    public static class StaticClassWithNestedClassWithNestedInterfaceWithGenericParameterClassAndInterfaceAndEmptyConstructorConstraints
    {
        public class Class
        {
            public interface Interface<T>
                where T : class, IInterface, new()
            {
            }
        }
    }
}
