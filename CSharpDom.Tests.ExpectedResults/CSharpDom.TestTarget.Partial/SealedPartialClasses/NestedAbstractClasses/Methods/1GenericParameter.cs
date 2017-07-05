namespace CSharpDom.TestTarget.Partial.SealedPartialClasses.NestedAbstractClasses.Methods
{
    public sealed partial class SealedPartialClassWithNestedAbstractClassWithMethodWith1GenericParameter
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
