namespace CSharpDom.TestTarget.AbstractClasses.NestedStaticClasses.NestedDelegates
{
    public abstract class AbstractClassWithNestedStaticClassWithNestedDelegateWithGenericParameterStructConstraint
    {
        public static class Class
        {
            public delegate void DelegateWithGenericParameterStructConstraint<T>()
                where T : struct;
        }
    }
}
