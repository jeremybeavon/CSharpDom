namespace CSharpDom.TestTarget.Partial.SealedPartialClasses.NestedClasses.Methods
{
    public sealed partial class SealedPartialClassWithNestedClassWithMethodWith1GenericParameter
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
