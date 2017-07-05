namespace CSharpDom.TestTarget.Partial.PartialClasses.NestedAbstractClasses.Methods
{
    public partial class PartialClassWithNestedAbstractClassWithMethodWith1GenericParameter
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
