namespace CSharpDom.TestTarget.Partial.AbstractClasses.NestedAbstractPartialClasses.NestedInterfaces
{
    public abstract class AbstractClassWithNestedAbstractPartialClassWithNestedInterfaceWithGenericParameterInterfaceConstraint
    {
        public abstract partial class Class
        {
            public interface Interface<T>
                where T : IInterface
            {
            }
        }
    }
}
