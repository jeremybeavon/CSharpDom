namespace CSharpDom.TestTarget.Partial.AbstractClasses.NestedAbstractPartialClasses.NestedInterfaces
{
    public abstract class AbstractClassWithNestedAbstractPartialClassWithNestedInterfaceWithGenericParameterBaseClassConstraint
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
