namespace CSharpDom.TestTarget.Partial.PartialStructs.NestedAbstractClasses.Methods
{
    public partial struct PartialStructWithWithNestedAbstractClassWithMethodWith1GenericParameter
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
