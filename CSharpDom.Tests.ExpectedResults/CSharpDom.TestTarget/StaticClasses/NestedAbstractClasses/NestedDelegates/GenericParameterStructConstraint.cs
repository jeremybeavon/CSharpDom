namespace CSharpDom.TestTarget.StaticClasses.NestedAbstractClasses.NestedDelegates
{
    public static class StaticClassWithNestedAbstractClassWithNestedDelegateWithGenericParameterStructConstraint
    {
        public abstract class Class
        {
            public delegate void DelegateWithGenericParameterStructConstraint<T>()
                where T : struct;
        }
    }
}
