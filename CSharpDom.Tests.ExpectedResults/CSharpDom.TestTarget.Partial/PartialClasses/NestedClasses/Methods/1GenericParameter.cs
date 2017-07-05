namespace CSharpDom.TestTarget.Partial.PartialClasses.NestedClasses.Methods
{
    public partial class PartialClassWithNestedClassWithMethodWith1GenericParameter
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
