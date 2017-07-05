namespace CSharpDom.TestTarget.Partial.Structs.NestedStaticPartialClasses.NestedDelegates
{
    public struct StructWithNestedStaticPartialClassWithNestedDelegateWithGenericParameterClassAndEmptyConstructorConstraints
    {
        public static partial class Class
        {
            public delegate void DelegateWithGenericParameterClassAndEmptyConstructorConstraints<T>()
                where T : class, new();
        }
    }
}
