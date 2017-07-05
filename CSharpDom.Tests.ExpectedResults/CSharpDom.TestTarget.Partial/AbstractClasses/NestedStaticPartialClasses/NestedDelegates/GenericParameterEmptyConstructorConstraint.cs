namespace CSharpDom.TestTarget.Partial.AbstractClasses.NestedStaticPartialClasses.NestedDelegates
{
    public abstract class AbstractClassWithNestedStaticPartialClassWithNestedDelegateWithGenericParameterEmptyConstructorConstraint
    {
        public static partial class Class
        {
            public delegate void DelegateWithGenericParameterEmptyConstructorConstraint<T>()
                where T : new();
        }
    }
}
