namespace CSharpDom.TestTarget.StaticClasses.NestedStaticClasses.NestedInterfaces
{
    public static class StaticClassWithNestedStaticClassWithNestedInterfaceWithGenericParameterGenericParameterConstraint
    {
        public static class Class
        {
            public interface Interface<TKey, TValue>
                where TKey : TValue
            {
            }
        }
    }
}
