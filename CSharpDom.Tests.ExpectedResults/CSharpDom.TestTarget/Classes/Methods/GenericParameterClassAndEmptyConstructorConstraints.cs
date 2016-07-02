namespace CSharpDom.TestTarget.Classes.Methods
{
    public class ClassWithMethodWithGenericParameterClassAndEmptyConstructorConstraints
    {
        public T Method<T>()
            where T : class, new()
        {
            return default(T);
        }
    }
}
