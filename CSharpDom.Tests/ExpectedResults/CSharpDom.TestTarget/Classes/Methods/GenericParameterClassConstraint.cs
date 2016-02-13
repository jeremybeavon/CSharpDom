namespace CSharpDom.TestTarget.Classes.Methods
{
    public class ClassWithMethodWithGenericParameterClassConstraint
    {
        public T Method<T>()
            where T : class
        {
            return default(T);
        }
    }
}
