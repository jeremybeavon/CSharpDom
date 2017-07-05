namespace CSharpDom.TestTarget.Partial.Classes.NestedSealedPartialClasses.Methods
{
    public class ClassWithNestedSealedPartialClassWithMethodWith1GenericParameter
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
