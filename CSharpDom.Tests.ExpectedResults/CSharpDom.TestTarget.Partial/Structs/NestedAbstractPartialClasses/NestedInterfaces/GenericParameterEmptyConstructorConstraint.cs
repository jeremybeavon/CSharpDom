namespace CSharpDom.TestTarget.Partial.Structs.NestedAbstractPartialClasses.NestedInterfaces
{
    public struct StructWithNestedAbstractPartialClassWithNestedInterfaceWithGenericParameterEmptyConstructorConstraint
    {
        public abstract partial class Class
        {
            public interface Interface<T>
                where T : new()
            {
            }
        }
    }
}
