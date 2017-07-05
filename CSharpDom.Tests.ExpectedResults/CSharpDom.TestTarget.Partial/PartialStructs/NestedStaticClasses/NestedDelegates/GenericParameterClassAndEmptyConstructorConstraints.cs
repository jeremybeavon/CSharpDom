namespace CSharpDom.TestTarget.Partial.PartialStructs.NestedStaticClasses.NestedDelegates
{
    public partial struct PartialStructWithWithNestedStaticClassWithNestedDelegateWithGenericParameterClassAndEmptyConstructorConstraints
    {
        public static class Class
        {
            public delegate void DelegateWithGenericParameterClassAndEmptyConstructorConstraints<T>()
                where T : class, new();
        }
    }
}
