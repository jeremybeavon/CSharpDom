namespace CSharpDom.TestTarget.Partial.PartialStructs.NestedAbstractClasses.NestedInterfaces
{
    public partial struct PartialStructWithWithNestedAbstractClassWithNestedInterfaceWithGenericParameterBaseClassConstraint
    {
        public abstract class Class
        {
            public interface Interface<T>
                where T : BaseClass
            {
            }
        }
    }
}
