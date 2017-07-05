namespace CSharpDom.TestTarget.Partial.SealedClasses.NestedStaticPartialClasses.Methods
{
    public sealed class SealedClassWithNestedStaticPartialClassWithMethodWith1GenericParameter
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
