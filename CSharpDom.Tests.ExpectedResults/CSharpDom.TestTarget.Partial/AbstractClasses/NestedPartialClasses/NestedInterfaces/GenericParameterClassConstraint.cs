namespace CSharpDom.TestTarget.Partial.AbstractClasses.NestedPartialClasses.NestedInterfaces
{
    public abstract class AbstractClassWithNestedPartialClassWithNestedInterfaceWithGenericParameterClassConstraint
    {
        public partial class Class
        {
            public interface Interface<T>
                where T : class
            {
            }
        }
    }
}
