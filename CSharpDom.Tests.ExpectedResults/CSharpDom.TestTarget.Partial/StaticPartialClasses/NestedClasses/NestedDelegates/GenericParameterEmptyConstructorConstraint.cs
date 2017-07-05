namespace CSharpDom.TestTarget.Partial.StaticPartialClasses.NestedClasses.NestedDelegates
{
    public static partial class StaticPartialClassWithNestedClassWithNestedDelegateWithGenericParameterEmptyConstructorConstraint
    {
        public class Class
        {
            public delegate void DelegateWithGenericParameterEmptyConstructorConstraint<T>()
                where T : new();
        }
    }
}
