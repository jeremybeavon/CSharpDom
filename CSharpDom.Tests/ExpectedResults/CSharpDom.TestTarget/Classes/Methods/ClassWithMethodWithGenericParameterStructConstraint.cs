namespace CSharpDom.TestTarget.Classes.Methods
{
    public class ClassWithMethodWithGenericParameterStructConstraint
    {
        public T Method<T>()
            where T : struct
        {
            return default(T);
        }
    }
}
