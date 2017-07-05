namespace CSharpDom.TestTarget.Partial.AbstractClasses.NestedPartialClasses.Methods
{
    public abstract class AbstractClassWithNestedPartialClassWithMethodWith1GenericParameter
    {
        public partial class Class
        {
            public T Method<T>()
            {
                return default(T);
            }
        }
    }
}
