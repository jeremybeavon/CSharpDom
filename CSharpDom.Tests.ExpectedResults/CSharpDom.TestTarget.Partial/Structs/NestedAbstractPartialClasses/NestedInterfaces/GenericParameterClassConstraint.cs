namespace CSharpDom.TestTarget.Partial.Structs.NestedAbstractPartialClasses.NestedInterfaces
{
    public struct StructWithNestedAbstractPartialClassWithNestedInterfaceWithGenericParameterClassConstraint
    {
        public abstract partial class Class
        {
            public interface Interface<T>
                where T : class
            {
            }
        }
    }
}
