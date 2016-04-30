namespace CSharpDom.TestTarget.StaticClasses.NestedClasses.Methods
{
    public static class StaticClassWithNestedClassWithMethodWithGenericParameterBaseClassConstraint
    {
        public class Class
        {
            public T Method<T>()
                where T : BaseClass
            {
                return default(T);
            }
        }
    }
}
