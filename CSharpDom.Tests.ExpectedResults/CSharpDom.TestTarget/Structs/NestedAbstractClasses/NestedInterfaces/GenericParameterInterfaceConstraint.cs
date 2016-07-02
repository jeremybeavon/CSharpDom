namespace CSharpDom.TestTarget.Structs.NestedAbstractClasses.NestedInterfaces
{
    public struct StructWithNestedAbstractClassWithNestedInterfaceWithGenericParameterInterfaceConstraint
    {
        public abstract class Class
        {
            public interface Interface<T>
                where T : IInterface
            {
            }
        }
    }
}
