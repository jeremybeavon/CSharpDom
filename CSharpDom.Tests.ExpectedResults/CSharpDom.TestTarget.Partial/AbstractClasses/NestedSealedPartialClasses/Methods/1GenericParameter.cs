namespace CSharpDom.TestTarget.Partial.AbstractClasses.NestedSealedPartialClasses.Methods
{
    public abstract class AbstractClassWithNestedSealedPartialClassWithMethodWith1GenericParameter
    {
        public sealed partial class Class
        {
            public T Method<T>()
            {
                return default(T);
            }
        }
    }
}
