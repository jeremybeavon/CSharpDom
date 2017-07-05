namespace CSharpDom.TestTarget.Partial.PartialStructs.NestedSealedClasses.NestedInterfaces
{
    public partial struct PartialStructWithWithNestedSealedClassWithNestedInterfaceWithGenericParameterEmptyConstructorConstraint
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
