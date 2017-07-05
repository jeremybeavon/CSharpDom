namespace CSharpDom.TestTarget.Partial.PartialClasses.Methods
{
    public partial class PartialClassWithMethodWith1GenericParameter
    {
        public T Method<T>()
        {
            return default(T);
        }
    }
}
