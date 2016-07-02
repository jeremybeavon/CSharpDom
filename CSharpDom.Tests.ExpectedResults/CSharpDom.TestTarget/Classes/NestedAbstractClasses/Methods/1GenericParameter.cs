namespace CSharpDom.TestTarget.Classes.NestedAbstractClasses.Methods
{
    public class ClassWithNestedAbstractClassWithMethodWith1GenericParameter
    {
        public abstract class Class
        {
            public T Method<T>()
            {
                return default(T);
            }
        }
    }
}
