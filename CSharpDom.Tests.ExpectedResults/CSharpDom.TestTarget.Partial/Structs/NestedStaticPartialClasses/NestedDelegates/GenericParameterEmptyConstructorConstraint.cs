namespace CSharpDom.TestTarget.Partial.Structs.NestedStaticPartialClasses.NestedDelegates
{
    public struct StructWithNestedStaticPartialClassWithNestedDelegateWithGenericParameterEmptyConstructorConstraint
    {
        public static partial class Class
        {
            public delegate void DelegateWithGenericParameterEmptyConstructorConstraint<T>()
                where T : new();
        }
    }
}
