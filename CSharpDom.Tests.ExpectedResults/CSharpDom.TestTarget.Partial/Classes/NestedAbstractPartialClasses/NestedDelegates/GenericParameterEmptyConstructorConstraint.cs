namespace CSharpDom.TestTarget.Partial.Classes.NestedAbstractPartialClasses.NestedDelegates
{
    public class ClassWithNestedAbstractPartialClassWithNestedDelegateWithGenericParameterEmptyConstructorConstraint
    {
        public abstract partial class Class
        {
            public delegate void DelegateWithGenericParameterEmptyConstructorConstraint<T>()
                where T : new();
        }
    }
}
