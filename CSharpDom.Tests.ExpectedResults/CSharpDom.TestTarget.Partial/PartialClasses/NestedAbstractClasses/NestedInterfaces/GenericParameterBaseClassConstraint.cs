namespace CSharpDom.TestTarget.Partial.PartialClasses.NestedAbstractClasses.NestedInterfaces
{
    public partial class PartialClassWithNestedAbstractClassWithNestedInterfaceWithGenericParameterBaseClassConstraint
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
