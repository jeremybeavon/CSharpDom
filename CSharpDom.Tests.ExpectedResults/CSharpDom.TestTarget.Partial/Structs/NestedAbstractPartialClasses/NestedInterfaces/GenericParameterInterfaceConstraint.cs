namespace CSharpDom.TestTarget.Partial.Structs.NestedAbstractPartialClasses.NestedInterfaces
{
    public struct StructWithNestedAbstractPartialClassWithNestedInterfaceWithGenericParameterInterfaceConstraint
    {
        public abstract partial class Class
        {
            public interface Interface<T>
                where T : IInterface
            {
            }
        }
    }
}
