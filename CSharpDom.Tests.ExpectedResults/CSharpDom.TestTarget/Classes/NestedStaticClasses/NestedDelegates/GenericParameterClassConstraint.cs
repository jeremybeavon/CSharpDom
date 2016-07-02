namespace CSharpDom.TestTarget.Classes.NestedStaticClasses.NestedDelegates
{
    public class ClassWithNestedStaticClassWithNestedClassWithNestedDelegateWithGenericParameterClassConstraint
    {
        public static class Class
        {
            public delegate void DelegateWithGenericParameterClassConstraint<T>()
                where T : class;
        }
    }
}
