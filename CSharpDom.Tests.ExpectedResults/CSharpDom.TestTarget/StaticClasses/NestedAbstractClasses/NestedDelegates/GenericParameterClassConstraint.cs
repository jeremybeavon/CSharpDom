namespace CSharpDom.TestTarget.StaticClasses.NestedAbstractClasses.NestedDelegates
{
    public static class StaticClassWithNestedAbstractClassWithNestedClassWithNestedDelegateWithGenericParameterClassConstraint
    {
        public abstract class Class
        {
            public delegate void DelegateWithGenericParameterClassConstraint<T>()
                where T : class;
        }
    }
}
