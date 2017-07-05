namespace CSharpDom.TestTarget.Partial.AbstractClasses.NestedPartialClasses.NestedInterfaces
{
    public abstract class AbstractClassWithNestedPartialClassWithNestedInterfaceWithGenericParameterBaseClassConstraint
    {
        public partial class Class
        {
            public interface Interface<T>
                where T : BaseClass
            {
            }
        }
    }
}
