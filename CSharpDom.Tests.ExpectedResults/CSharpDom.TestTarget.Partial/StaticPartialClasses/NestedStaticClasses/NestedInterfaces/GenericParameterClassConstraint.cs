namespace CSharpDom.TestTarget.Partial.StaticPartialClasses.NestedStaticClasses.NestedInterfaces
{
    public static partial class StaticPartialClassWithNestedStaticClassWithNestedInterfaceWithGenericParameterClassConstraint
    {
        public static class Class
        {
            public interface Interface<T>
                where T : class
            {
            }
        }
    }
}
