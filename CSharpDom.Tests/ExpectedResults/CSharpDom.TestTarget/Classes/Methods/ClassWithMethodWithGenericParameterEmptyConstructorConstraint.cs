namespace CSharpDom.TestTarget.Classes.Methods
{
    public class ClassWithMethodWithGenericParameterEmptyConstructorConstraint
    {
        public T Method<T>()
            where T : new()
        {
            return default(T);
        }
    }
}
