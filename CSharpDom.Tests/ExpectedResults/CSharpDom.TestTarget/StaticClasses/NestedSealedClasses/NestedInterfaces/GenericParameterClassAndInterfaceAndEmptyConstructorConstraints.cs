namespace CSharpDom.TestTarget.StaticClasses.NestedSealedClasses.NestedInterfaces
{
    public static class StaticClassWithNestedSealedClassWithNestedInterfaceWithGenericParameterClassAndInterfaceAndEmptyConstructorConstraints
    {
        public sealed class Class
        {
            public interface Interface<T>
                where T : class, IInterface, new()
            {
            }
        }
    }
}
