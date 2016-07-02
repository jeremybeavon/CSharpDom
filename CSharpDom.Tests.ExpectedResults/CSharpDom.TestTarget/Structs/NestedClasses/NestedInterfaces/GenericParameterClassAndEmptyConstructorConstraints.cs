namespace CSharpDom.TestTarget.Structs.NestedClasses.NestedInterfaces
{
    public struct StructWithNestedClassWithNestedInterfaceWithGenericParameterClassAndEmptyConstructorConstraints
    {
        public class Class
        {
            public interface Interface<T>
                where T : class, new()
            {
            }
        }
    }
}
