namespace CSharpDom.TestTarget.Classes.NestedClasses.Methods
{
    public class ClassWithNestedClassWithMethodWith1GenericParameter
    {
        public class Class
        {
            public T Method<T>()
            {
                return default(T);
            }
        }
    }
}
