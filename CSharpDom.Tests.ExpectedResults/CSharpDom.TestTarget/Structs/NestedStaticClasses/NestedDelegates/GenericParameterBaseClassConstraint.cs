namespace CSharpDom.TestTarget.Structs.NestedStaticClasses.NestedDelegates
{
    public struct StructWithNestedStaticClassWithNestedDelegateWithGenericParameterBaseClassConstraint
    {
        public static class Class
        {
            public delegate void DelegateWithGenericParameterBaseClassConstraint<T>()
                where T : BaseClass;
        }
    }
}
