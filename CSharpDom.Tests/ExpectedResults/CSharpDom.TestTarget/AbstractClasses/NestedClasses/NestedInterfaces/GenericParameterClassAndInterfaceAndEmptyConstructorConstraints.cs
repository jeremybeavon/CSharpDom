namespace CSharpDom.TestTarget.AbstractClasses.NestedClasses.NestedInterfaces
{
    public abstract class AbstractClassWithNestedClassWithNestedInterfaceWithGenericParameterClassAndInterfaceAndEmptyConstructorConstraints
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
