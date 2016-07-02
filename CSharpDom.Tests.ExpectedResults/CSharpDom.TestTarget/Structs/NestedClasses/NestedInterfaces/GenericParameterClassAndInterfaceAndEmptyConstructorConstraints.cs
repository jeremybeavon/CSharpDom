namespace CSharpDom.TestTarget.Structs.NestedClasses.NestedInterfaces
{
    public struct StructWithNestedClassWithNestedInterfaceWithGenericParameterClassAndInterfaceAndEmptyConstructorConstraints
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
