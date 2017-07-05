namespace CSharpDom.TestTarget.Partial.AbstractPartialClasses.NestedStaticClasses.NestedInterfaces
{
    public abstract partial class AbstractPartialClassWithNestedStaticClassWithNestedInterfaceWithGenericParameterBaseClassConstraint
    {
        public static class Class
        {
            public interface Interface<T>
                where T : BaseClass
            {
            }
        }
    }
}
