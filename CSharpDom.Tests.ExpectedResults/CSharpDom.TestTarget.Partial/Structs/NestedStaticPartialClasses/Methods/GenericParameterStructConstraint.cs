namespace CSharpDom.TestTarget.Partial.Structs.NestedStaticPartialClasses.Methods
{
    public struct StructWithNestedStaticPartialClassWithMethodWithGenericParameterStructConstraint
    {
        public static partial class Class
        {
            public static T Method<T>()
                where T : struct
            {
                return default(T);
            }
        }
    }
}
