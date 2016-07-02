namespace CSharpDom.TestTarget.AbstractClasses.NestedStaticClasses.NestedDelegates
{
    public abstract class AbstractClassWithNestedStaticClassWithNestedDelegateWithGenericParameterClassAndEmptyConstructorConstraints
    {
        public static class Class
        {
            public delegate void DelegateWithGenericParameterClassAndEmptyConstructorConstraints<T>()
                where T : class, new();
        }
    }
}
