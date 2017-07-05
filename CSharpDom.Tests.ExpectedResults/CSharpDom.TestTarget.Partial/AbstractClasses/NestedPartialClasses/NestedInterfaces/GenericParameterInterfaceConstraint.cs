namespace CSharpDom.TestTarget.Partial.AbstractClasses.NestedPartialClasses.NestedInterfaces
{
    public abstract class AbstractClassWithNestedPartialClassWithNestedInterfaceWithGenericParameterInterfaceConstraint
    {
        public partial class Class
        {
            public interface Interface<T>
                where T : IInterface
            {
            }
        }
    }
}
