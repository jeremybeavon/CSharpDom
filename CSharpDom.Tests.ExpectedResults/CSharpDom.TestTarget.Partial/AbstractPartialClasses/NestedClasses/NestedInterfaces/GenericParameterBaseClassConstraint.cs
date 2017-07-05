namespace CSharpDom.TestTarget.Partial.AbstractPartialClasses.NestedClasses.NestedInterfaces
{
    public abstract partial class AbstractPartialClassWithNestedClassWithNestedInterfaceWithGenericParameterBaseClassConstraint
    {
        public class Class
        {
            public interface Interface<T>
                where T : BaseClass
            {
            }
        }
    }
}
