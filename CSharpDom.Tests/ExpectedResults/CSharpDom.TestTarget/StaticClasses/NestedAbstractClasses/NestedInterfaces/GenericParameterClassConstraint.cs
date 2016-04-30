namespace CSharpDom.TestTarget.StaticClasses.NestedAbstractClasses.NestedInterfaces
{
    public static class StaticClassWithNestedAbstractClassWithNestedInterfaceWithGenericParameterClassConstraint
    {
        public abstract class Class
        {
            public interface Interface<T>
                where T : class
            {
            }
        }
    }
}
