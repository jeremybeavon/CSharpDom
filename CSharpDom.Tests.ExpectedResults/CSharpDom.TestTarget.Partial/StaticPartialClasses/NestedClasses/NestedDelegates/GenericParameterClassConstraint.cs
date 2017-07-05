namespace CSharpDom.TestTarget.Partial.StaticPartialClasses.NestedClasses.NestedDelegates
{
    public static partial class StaticPartialClassWithNestedClassWithNestedClassWithNestedDelegateWithGenericParameterClassConstraint
    {
        public class Class
        {
            public delegate void DelegateWithGenericParameterClassConstraint<T>()
                where T : class;
        }
    }
}
