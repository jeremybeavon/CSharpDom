namespace CSharpDom.TestTarget.Partial.StaticClasses.NestedStaticPartialClasses.NestedInterfaces
{
    public static class StaticClassWithNestedStaticPartialClassWithNestedInterfaceWithGenericParameterClassAndEmptyConstructorConstraints
    {
        public static partial class Class
        {
            public interface Interface<T>
                where T : class, new()
            {
            }
        }
    }
}
