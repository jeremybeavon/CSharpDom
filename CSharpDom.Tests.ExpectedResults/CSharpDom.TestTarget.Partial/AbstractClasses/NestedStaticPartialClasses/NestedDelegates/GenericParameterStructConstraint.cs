namespace CSharpDom.TestTarget.Partial.AbstractClasses.NestedStaticPartialClasses.NestedDelegates
{
    public abstract class AbstractClassWithNestedStaticPartialClassWithNestedDelegateWithGenericParameterStructConstraint
    {
        public static partial class Class
        {
            public delegate void DelegateWithGenericParameterStructConstraint<T>()
                where T : struct;
        }
    }
}
