namespace CSharpDom.TestTarget.Structs.NestedSealedClasses.NestedInterfaces
{
    public struct StructWithNestedSealedClassWithNestedInterfaceWithGenericParameterInterfaceConstraint
    {
        public sealed class Class
        {
            public interface Interface<T>
                where T : IInterface
            {
            }
        }
    }
}
