namespace CSharpDom.TestTarget.Partial.StaticPartialClasses.Methods
{
    public static partial class StaticPartialClassWithMethodWith1GenericParameter
    {
        public static T Method<T>()
        {
            return default(T);
        }
    }
}
