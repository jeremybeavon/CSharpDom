namespace CSharpDom.TestTarget.Partial.SealedClasses.NestedPartialClasses.Methods
{
    public sealed class SealedClassWithNestedPartialClassWithMethodWith1GenericParameter
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
