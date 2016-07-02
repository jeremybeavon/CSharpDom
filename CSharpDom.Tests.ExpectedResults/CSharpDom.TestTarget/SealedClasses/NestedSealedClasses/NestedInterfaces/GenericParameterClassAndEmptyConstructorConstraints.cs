namespace CSharpDom.TestTarget.SealedClasses.NestedSealedClasses.NestedInterfaces
{
    public sealed class SealedClassWithNestedSealedClassWithNestedInterfaceWithGenericParameterClassAndEmptyConstructorConstraints
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
