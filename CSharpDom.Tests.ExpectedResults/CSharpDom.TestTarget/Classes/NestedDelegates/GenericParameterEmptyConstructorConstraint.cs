namespace CSharpDom.TestTarget.Classes.NestedDelegates
{
    public class ClassWithNestedDelegateWithGenericParameterEmptyConstructorConstraint
    {
        public delegate void DelegateWithGenericParameterEmptyConstructorConstraint<T>()
            where T : new();
    }
}
