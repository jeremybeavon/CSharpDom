namespace CSharpDom.TestTarget.Partial.Classes.NestedStaticPartialClasses.NestedDelegates
{
    public class ClassWithNestedStaticPartialClassWithNestedDelegateWithGenericParameterEmptyConstructorConstraint
    {
        public static partial class Class
        {
            public delegate void DelegateWithGenericParameterEmptyConstructorConstraint<T>()
                where T : new();
        }
    }
}
