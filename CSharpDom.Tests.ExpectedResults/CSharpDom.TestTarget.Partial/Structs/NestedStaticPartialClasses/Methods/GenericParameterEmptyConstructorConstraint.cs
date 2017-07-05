namespace CSharpDom.TestTarget.Partial.Structs.NestedStaticPartialClasses.Methods
{
    public struct StructWithNestedStaticPartialClassWithMethodWithGenericParameterEmptyConstructorConstraint
    {
        public static partial class Class
        {
            public static T Method<T>()
                where T : new()
            {
                return default(T);
            }
        }
    }
}
