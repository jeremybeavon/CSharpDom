namespace CSharpDom.TestTarget.Classes.NestedStaticClasses.Methods
{
    public class ClassWithNestedStaticClassWithMethodWith1GenericParameter
    {
        public static class Class
        {
            public static T Method<T>()
            {
                return default(T);
            }
        }
    }
}
