namespace CSharpDom.TestTarget.StaticClasses.NestedSealedClasses.NestedInterfaces
{
    public static class StaticClassWithNestedSealedClassWithNestedInterfaceWithGenericParameterClassAndEmptyConstructorConstraints
    {
        public sealed class Class
        {
            public interface Interface<T>
                where T : class, new()
            {
            }
        }
    }
}
