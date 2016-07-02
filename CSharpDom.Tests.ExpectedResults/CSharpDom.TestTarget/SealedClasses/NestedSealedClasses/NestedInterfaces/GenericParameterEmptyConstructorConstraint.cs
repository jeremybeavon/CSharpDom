namespace CSharpDom.TestTarget.SealedClasses.NestedSealedClasses.NestedInterfaces
{
    public sealed class SealedClassWithNestedSealedClassWithNestedInterfaceWithGenericParameterEmptyConstructorConstraint
    {
        public sealed class Class
        {
            public interface Interface<T>
                where T : new()
            {
            }
        }
    }
}
