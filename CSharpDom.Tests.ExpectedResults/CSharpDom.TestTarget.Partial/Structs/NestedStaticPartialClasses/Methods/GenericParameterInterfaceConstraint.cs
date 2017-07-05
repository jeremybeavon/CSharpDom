namespace CSharpDom.TestTarget.Partial.Structs.NestedStaticPartialClasses.Methods
{
    public struct StructWithNestedStaticPartialClassWithMethodWithGenericParameterInterfaceConstraint
    {
        public static partial class Class
        {
            public static T Method<T>()
                where T : IInterface
            {
                return default(T);
            }
        }
    }
}
