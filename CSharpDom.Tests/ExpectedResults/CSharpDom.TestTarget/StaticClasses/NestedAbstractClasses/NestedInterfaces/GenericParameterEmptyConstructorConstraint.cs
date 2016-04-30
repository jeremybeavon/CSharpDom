namespace CSharpDom.TestTarget.StaticClasses.NestedAbstractClasses.NestedInterfaces
{
    public static class StaticClassWithNestedAbstractClassWithNestedInterfaceWithGenericParameterEmptyConstructorConstraint
    {
        public abstract class Class
        {
            public interface Interface<T>
                where T : new()
            {
            }
        }
    }
}
