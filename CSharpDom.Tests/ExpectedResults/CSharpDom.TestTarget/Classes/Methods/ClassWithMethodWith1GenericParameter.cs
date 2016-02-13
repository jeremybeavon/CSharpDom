namespace CSharpDom.TestTarget.Classes.Methods
{
    public class ClassWithMethodWith1GenericParameter
    {
        public T Method<T>()
        {
            return default(T);
        }
    }
}
