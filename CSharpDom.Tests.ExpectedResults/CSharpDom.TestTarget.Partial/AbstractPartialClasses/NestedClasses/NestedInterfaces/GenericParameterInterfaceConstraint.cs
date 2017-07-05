namespace CSharpDom.TestTarget.Partial.AbstractPartialClasses.NestedClasses.NestedInterfaces
{
    public abstract partial class AbstractPartialClassWithNestedClassWithNestedInterfaceWithGenericParameterInterfaceConstraint
    {
        public class Class
        {
            public interface Interface<T>
                where T : IInterface
            {
            }
        }
    }
}
