namespace CSharpDom.TestTarget.StaticClasses.NestedStaticClasses.NestedDelegates
{
    public static class StaticClassWithNestedStaticClassWithNestedDelegateWithGenericParameterBaseClassConstraint
    {
        public static class Class
        {
            public delegate void DelegateWithGenericParameterBaseClassConstraint<T>()
                where T : BaseClass;
        }
    }
}
