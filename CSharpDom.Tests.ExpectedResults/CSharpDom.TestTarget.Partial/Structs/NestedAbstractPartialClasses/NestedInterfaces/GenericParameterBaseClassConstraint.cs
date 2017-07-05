namespace CSharpDom.TestTarget.Partial.Structs.NestedAbstractPartialClasses.NestedInterfaces
{
    public struct StructWithNestedAbstractPartialClassWithNestedInterfaceWithGenericParameterBaseClassConstraint
    {
        public abstract partial class Class
        {
            public interface Interface<T>
                where T : BaseClass
            {
            }
        }
    }
}
