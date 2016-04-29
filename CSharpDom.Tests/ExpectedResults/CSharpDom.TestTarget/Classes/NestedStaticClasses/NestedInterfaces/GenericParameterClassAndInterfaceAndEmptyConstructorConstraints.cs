namespace CSharpDom.TestTarget.Classes.NestedStaticClasses.NestedInterfaces
{
    public class ClassWithNestedStaticClassWithNestedInterfaceWithGenericParameterClassAndInterfaceAndEmptyConstructorConstraints
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
