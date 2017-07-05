namespace CSharpDom.TestTarget.Partial.AbstractPartialClasses.NestedAbstractClasses.NestedInterfaces
{
    public abstract partial class AbstractPartialClassWithNestedAbstractClassWithNestedInterfaceWithGenericParameterClassConstraint
    {
        public abstract class Class
        {
            public interface Interface<T>
                where T : class
            {
            }
        }
    }
}
