namespace CSharpDom.TestTarget.Structs.NestedStaticClasses.NestedDelegates
{
    public struct StructWithNestedStaticClassWithNestedClassWithNestedDelegateWithGenericParameterClassConstraint
    {
        public static class Class
        {
            public delegate void DelegateWithGenericParameterClassConstraint<T>()
                where T : class;
        }
    }
}
