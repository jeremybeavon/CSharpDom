namespace CSharpDom.TestTarget.Partial.Structs.NestedAbstractPartialClasses.NestedInterfaces
{
    public struct StructWithNestedAbstractPartialClassWithNestedInterfaceWithGenericParameterClassAndEmptyConstructorConstraints
    {
        public abstract partial class Class
        {
            public interface Interface<T>
                where T : class, new()
            {
            }
        }
    }
}
