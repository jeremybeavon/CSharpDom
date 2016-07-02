namespace CSharpDom.TestTarget.StaticClasses.NestedStaticClasses.NestedInterfaces
{
    public static class StaticClassWithNestedStaticClassWithNestedInterfaceWithGenericParameterBaseClassConstraint
    {
        public static class Class
        {
            public interface Interface<T>
                where T : BaseClass
            {
            }
        }
    }
}
