namespace CSharpDom.TestTarget.StaticClasses.NestedStaticClasses.NestedInterfaces
{
    public static class StaticClassWithNestedStaticClassWithNestedInterfaceWithGenericParameterStructConstraint
    {
        public static class Class
        {
            public interface Interface<T>
                where T : struct
            {
            }
        }
    }
}
