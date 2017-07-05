namespace CSharpDom.TestTarget.Partial.Classes.NestedStaticPartialClasses.NestedDelegates
{
    public class ClassWithNestedStaticPartialClassWithNestedDelegateWithGenericParameterClassConstraint
    {
        public static partial class Class
        {
            public delegate void DelegateWithGenericParameterClassConstraint<T>()
                where T : class;
        }
    }
}
