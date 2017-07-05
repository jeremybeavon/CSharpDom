namespace CSharpDom.TestTarget.Partial.Classes.NestedPartialClasses.Methods
{
    public class ClassWithNestedPartialClassWithMethodWith1GenericParameter
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
