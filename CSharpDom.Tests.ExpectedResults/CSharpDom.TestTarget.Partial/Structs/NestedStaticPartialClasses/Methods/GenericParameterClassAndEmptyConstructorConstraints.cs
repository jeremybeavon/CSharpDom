namespace CSharpDom.TestTarget.Partial.Structs.NestedStaticPartialClasses.Methods
{
    public struct StructWithNestedStaticPartialClassWithMethodWithGenericParameterClassAndEmptyConstructorConstraints
    {
        public static partial class Class
        {
            public static T Method<T>()
                where T : class, new()
            {
                return default(T);
            }
        }
    }
}
