namespace CSharpDom.TestTarget.SealedClasses.NestedStaticClasses.NestedInterfaces
{
    public sealed class SealedClassWithNestedStaticClassWithNestedInterfaceWithGenericParameterClassAndEmptyConstructorConstraints
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
