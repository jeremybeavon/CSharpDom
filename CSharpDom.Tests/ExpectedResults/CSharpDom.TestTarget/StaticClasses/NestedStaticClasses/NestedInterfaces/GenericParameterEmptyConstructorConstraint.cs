namespace CSharpDom.TestTarget.StaticClasses.NestedStaticClasses.NestedInterfaces
{
    public static class StaticClassWithNestedStaticClassWithNestedInterfaceWithGenericParameterEmptyConstructorConstraint
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
