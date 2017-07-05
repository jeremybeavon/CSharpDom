namespace CSharpDom.TestTarget.Partial.StaticClasses.NestedAbstractPartialClasses.NestedInterfaces
{
    public static class StaticClassWithNestedAbstractPartialClassWithNestedInterfaceWithGenericParameterClassConstraint
    {
        public abstract partial class Class
        {
            public interface Interface<T>
                where T : class
            {
            }
        }
    }
}
