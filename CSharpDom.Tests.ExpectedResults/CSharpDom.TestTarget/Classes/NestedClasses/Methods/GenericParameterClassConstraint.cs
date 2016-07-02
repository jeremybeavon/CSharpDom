namespace CSharpDom.TestTarget.Classes.NestedClasses.Methods
{
    public class ClassWithNestedClassWithMethodWithGenericParameterClassConstraint
    {
        public class Class
        {
            public T Method<T>()
                where T : class
            {
                return default(T);
            }
        }
    }
}
