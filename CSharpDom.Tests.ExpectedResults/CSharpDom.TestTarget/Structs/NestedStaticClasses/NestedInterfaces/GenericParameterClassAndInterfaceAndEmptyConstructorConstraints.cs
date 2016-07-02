namespace CSharpDom.TestTarget.Structs.NestedStaticClasses.NestedInterfaces
{
    public struct StructWithNestedStaticClassWithNestedInterfaceWithGenericParameterClassAndInterfaceAndEmptyConstructorConstraints
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
