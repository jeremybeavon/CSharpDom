namespace CSharpDom.TestTarget.StaticClasses.NestedClasses.NestedDelegates
{
    public static class StaticClassWithNestedClassWithNestedDelegateWithGenericParameterEmptyConstructorConstraint
    {
        public class Class
        {
            public delegate void DelegateWithGenericParameterEmptyConstructorConstraint<T>()
                where T : new();
        }
    }
}
