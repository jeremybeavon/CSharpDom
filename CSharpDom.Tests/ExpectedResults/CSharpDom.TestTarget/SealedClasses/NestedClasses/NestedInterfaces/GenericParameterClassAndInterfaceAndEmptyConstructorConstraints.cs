namespace CSharpDom.TestTarget.SealedClasses.NestedClasses.NestedInterfaces
{
    public sealed class SealedClassWithNestedClassWithNestedInterfaceWithGenericParameterClassAndInterfaceAndEmptyConstructorConstraints
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
