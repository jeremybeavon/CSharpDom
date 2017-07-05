namespace CSharpDom.TestTarget.Partial.SealedPartialClasses.Methods
{
    public sealed partial class SealedPartialClassWithMethodWith1GenericParameter
    {
        public T Method<T>()
        {
            return default(T);
        }
    }
}
