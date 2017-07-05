namespace CSharpDom.TestTarget.Partial.StaticClasses.NestedAbstractPartialClasses.NestedInterfaces
{
    public static class StaticClassWithNestedAbstractPartialClassWithNestedInterfaceWithGenericParameterClassAndEmptyConstructorConstraints
    {
        public abstract partial class Class
        {
            public interface Interface<T>
                where T : class, new()
            {
            }
        }
    }
}
