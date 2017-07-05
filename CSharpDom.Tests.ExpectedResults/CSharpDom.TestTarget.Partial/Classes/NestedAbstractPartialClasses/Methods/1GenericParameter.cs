namespace CSharpDom.TestTarget.Partial.Classes.NestedAbstractPartialClasses.Methods
{
    public class ClassWithNestedAbstractPartialClassWithMethodWith1GenericParameter
    {
        public abstract partial class Class
        {
            public T Method<T>()
            {
                return default(T);
            }
        }
    }
}
