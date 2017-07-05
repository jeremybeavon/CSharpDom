namespace CSharpDom.TestTarget.Partial.PartialStructs.NestedStaticClasses.NestedDelegates
{
    public partial struct PartialStructWithWithNestedStaticClassWithNestedDelegateWithGenericParameterEmptyConstructorConstraint
    {
        public static class Class
        {
            public delegate void DelegateWithGenericParameterEmptyConstructorConstraint<T>()
                where T : new();
        }
    }
}
