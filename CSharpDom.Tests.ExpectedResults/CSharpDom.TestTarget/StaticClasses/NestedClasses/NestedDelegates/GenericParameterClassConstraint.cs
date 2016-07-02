namespace CSharpDom.TestTarget.StaticClasses.NestedClasses.NestedDelegates
{
    public static class StaticClassWithNestedClassWithNestedClassWithNestedDelegateWithGenericParameterClassConstraint
    {
        public class Class
        {
            public delegate void DelegateWithGenericParameterClassConstraint<T>()
                where T : class;
        }
    }
}
