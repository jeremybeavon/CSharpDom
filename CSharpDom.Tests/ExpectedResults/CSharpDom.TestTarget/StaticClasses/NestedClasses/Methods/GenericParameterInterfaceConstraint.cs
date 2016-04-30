namespace CSharpDom.TestTarget.StaticClasses.NestedClasses.Methods
{
    public static class StaticClassWithNestedClassWithMethodWithGenericParameterInterfaceConstraint
    {
        public class Class
        {
            public T Method<T>()
                where T : IInterface
            {
                return default(T);
            }
        }
    }
}
