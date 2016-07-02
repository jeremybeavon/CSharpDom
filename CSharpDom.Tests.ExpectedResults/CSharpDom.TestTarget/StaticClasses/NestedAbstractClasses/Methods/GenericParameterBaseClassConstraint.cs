namespace CSharpDom.TestTarget.StaticClasses.NestedAbstractClasses.Methods
{
    public static class StaticClassWithNestedAbstractClassWithMethodWithGenericParameterBaseClassConstraint
    {
        public abstract class Class
        {
            public T Method<T>()
                where T : BaseClass
            {
                return default(T);
            }
        }
    }
}
