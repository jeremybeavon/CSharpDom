namespace CSharpDom.TestTarget.Structs.NestedStaticClasses.NestedDelegates
{
    public struct StructWithNestedStaticClassWithNestedDelegateWithGenericParameterEmptyConstructorConstraint
    {
        public static class Class
        {
            public delegate void DelegateWithGenericParameterEmptyConstructorConstraint<T>()
                where T : new();
        }
    }
}
