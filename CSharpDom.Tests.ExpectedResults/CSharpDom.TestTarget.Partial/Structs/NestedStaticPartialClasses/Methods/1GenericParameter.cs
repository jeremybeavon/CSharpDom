namespace CSharpDom.TestTarget.Partial.Structs.NestedStaticPartialClasses.Methods
{
    public struct StructWithNestedStaticPartialClassWithMethodWith1GenericParameter
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
