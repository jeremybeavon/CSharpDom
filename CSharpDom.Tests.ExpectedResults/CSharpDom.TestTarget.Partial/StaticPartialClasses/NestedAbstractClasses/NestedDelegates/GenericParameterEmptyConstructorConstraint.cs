namespace CSharpDom.TestTarget.Partial.StaticPartialClasses.NestedAbstractClasses.NestedDelegates
{
    public static partial class StaticPartialClassWithNestedAbstractClassWithNestedDelegateWithGenericParameterEmptyConstructorConstraint
    {
        public abstract class Class
        {
            public delegate void DelegateWithGenericParameterEmptyConstructorConstraint<T>()
                where T : new();
        }
    }
}
