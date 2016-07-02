namespace CSharpDom.TestTarget.StaticClasses.NestedStaticClasses.NestedInterfaces
{
    public static class StaticClassWithNestedStaticClassWithNestedInterfaceWithGenericParameterClassConstraint
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
