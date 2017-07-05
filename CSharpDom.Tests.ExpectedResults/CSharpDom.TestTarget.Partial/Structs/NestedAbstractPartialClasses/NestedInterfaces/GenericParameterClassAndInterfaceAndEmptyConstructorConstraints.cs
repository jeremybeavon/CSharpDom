namespace CSharpDom.TestTarget.Partial.Structs.NestedAbstractPartialClasses.NestedInterfaces
{
    public struct StructWithNestedAbstractPartialClassWithNestedInterfaceWithGenericParameterClassAndInterfaceAndEmptyConstructorConstraints
    {
        public abstract partial class Class
        {
            public interface Interface<T>
                where T : class, IInterface, new()
            {
            }
        }
    }
}
