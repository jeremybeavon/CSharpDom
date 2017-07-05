namespace CSharpDom.TestTarget.Partial.StaticPartialClasses.NestedStaticClasses.NestedInterfaces
{
    public static partial class StaticPartialClassWithNestedStaticClassWithNestedInterfaceWithGenericParameterEmptyConstructorConstraint
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
