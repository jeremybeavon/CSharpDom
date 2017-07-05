namespace CSharpDom.TestTarget.Partial.PartialStructs.NestedSealedClasses.NestedInterfaces
{
    public partial struct PartialStructWithWithNestedSealedClassWithNestedInterfaceWithGenericParameterClassAndEmptyConstructorConstraints
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
