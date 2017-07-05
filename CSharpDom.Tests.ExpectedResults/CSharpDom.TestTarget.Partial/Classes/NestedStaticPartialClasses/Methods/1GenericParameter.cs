namespace CSharpDom.TestTarget.Partial.Classes.NestedStaticPartialClasses.Methods
{
    public class ClassWithNestedStaticPartialClassWithMethodWith1GenericParameter
    {
        public static partial class Class
        {
            public static T Method<T>()
            {
                return default(T);
            }
        }
    }
}
