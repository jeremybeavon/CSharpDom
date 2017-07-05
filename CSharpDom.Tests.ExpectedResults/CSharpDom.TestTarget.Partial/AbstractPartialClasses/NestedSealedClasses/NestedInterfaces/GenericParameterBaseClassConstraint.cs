namespace CSharpDom.TestTarget.Partial.AbstractPartialClasses.NestedSealedClasses.NestedInterfaces
{
    public abstract partial class AbstractPartialClassWithNestedSealedClassWithNestedInterfaceWithGenericParameterBaseClassConstraint
    {
        public sealed class Class
        {
            public interface Interface<T>
                where T : BaseClass
            {
            }
        }
    }
}
