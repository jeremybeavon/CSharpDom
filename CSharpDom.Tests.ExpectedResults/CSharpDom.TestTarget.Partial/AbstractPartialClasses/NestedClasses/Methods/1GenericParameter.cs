namespace CSharpDom.TestTarget.Partial.AbstractPartialClasses.NestedClasses.Methods
{
    public abstract partial class AbstractPartialClassWithNestedClassWithMethodWith1GenericParameter
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
