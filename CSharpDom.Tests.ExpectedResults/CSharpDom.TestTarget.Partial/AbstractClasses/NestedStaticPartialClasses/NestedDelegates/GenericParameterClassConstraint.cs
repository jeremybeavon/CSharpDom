namespace CSharpDom.TestTarget.Partial.AbstractClasses.NestedStaticPartialClasses.NestedDelegates
{
    public abstract class AbstractClassWithNestedStaticPartialClassWithNestedDelegateWithGenericParameterClassConstraint
    {
        public static partial class Class
        {
            public delegate void DelegateWithGenericParameterClassConstraint<T>()
                where T : class;
        }
    }
}
