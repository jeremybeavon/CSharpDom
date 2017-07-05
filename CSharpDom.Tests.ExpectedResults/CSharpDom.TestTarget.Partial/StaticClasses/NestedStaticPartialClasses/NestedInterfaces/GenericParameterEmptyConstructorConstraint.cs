namespace CSharpDom.TestTarget.Partial.StaticClasses.NestedStaticPartialClasses.NestedInterfaces
{
    public static class StaticClassWithNestedStaticPartialClassWithNestedInterfaceWithGenericParameterEmptyConstructorConstraint
    {
        public static partial class Class
        {
            public interface Interface<T>
                where T : new()
            {
            }
        }
    }
}
