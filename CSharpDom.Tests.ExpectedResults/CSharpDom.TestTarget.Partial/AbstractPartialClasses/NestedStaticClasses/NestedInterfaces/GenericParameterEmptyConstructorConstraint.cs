namespace CSharpDom.TestTarget.Partial.AbstractPartialClasses.NestedStaticClasses.NestedInterfaces
{
    public abstract partial class AbstractPartialClassWithNestedStaticClassWithNestedInterfaceWithGenericParameterEmptyConstructorConstraint
    {
        public static class Class
        {
            public interface Interface<T>
                where T : new()
            {
            }
        }
    }
}
