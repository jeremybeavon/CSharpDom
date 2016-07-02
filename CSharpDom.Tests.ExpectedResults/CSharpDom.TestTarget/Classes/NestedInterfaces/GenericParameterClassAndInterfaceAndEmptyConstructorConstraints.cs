namespace CSharpDom.TestTarget.Classes.NestedInterfaces
{
    public class ClassWithNestedInterfaceWithGenericParameterClassAndInterfaceAndEmptyConstructorConstraints
    {
        public interface Interface<T>
            where T : class, IInterface, new()
        {
        }
    }
}
