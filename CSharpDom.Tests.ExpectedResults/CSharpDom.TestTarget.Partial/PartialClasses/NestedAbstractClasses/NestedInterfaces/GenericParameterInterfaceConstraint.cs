namespace CSharpDom.TestTarget.Partial.PartialClasses.NestedAbstractClasses.NestedInterfaces
{
    public partial class PartialClassWithNestedAbstractClassWithNestedInterfaceWithGenericParameterInterfaceConstraint
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
