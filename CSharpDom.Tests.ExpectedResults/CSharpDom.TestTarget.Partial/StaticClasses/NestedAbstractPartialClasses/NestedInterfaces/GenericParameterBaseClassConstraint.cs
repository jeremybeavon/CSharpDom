namespace CSharpDom.TestTarget.Partial.StaticClasses.NestedAbstractPartialClasses.NestedInterfaces
{
    public static class StaticClassWithNestedAbstractPartialClassWithNestedInterfaceWithGenericParameterBaseClassConstraint
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
