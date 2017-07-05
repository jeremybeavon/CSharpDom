namespace CSharpDom.TestTarget.Partial.AbstractClasses.NestedStaticPartialClasses.Methods
{
    public abstract class AbstractClassWithNestedStaticPartialClassWithMethodWith1GenericParameter
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
