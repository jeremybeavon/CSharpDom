namespace CSharpDom.TestTarget.SealedClasses.NestedStaticClasses.NestedInterfaces
{
    public sealed class SealedClassWithNestedStaticClassWithNestedInterfaceWithGenericParameterEmptyConstructorConstraint
    {
        public static class Class
        {
            public interface Interface<T>
                where T : new()
            {
            }
        }
    }
}
