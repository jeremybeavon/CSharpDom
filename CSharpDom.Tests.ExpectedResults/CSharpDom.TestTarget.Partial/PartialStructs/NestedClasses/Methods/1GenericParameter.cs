namespace CSharpDom.TestTarget.Partial.PartialStructs.NestedClasses.Methods
{
    public partial struct PartialStructWithWithNestedClassWithMethodWith1GenericParameter
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
