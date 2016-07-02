namespace CSharpDom.TestTarget.StaticClasses.Methods
{
    public static class StaticClassWithMethodWith1GenericParameter
    {
        public static T Method<T>()
        {
            return default(T);
        }
    }
}
