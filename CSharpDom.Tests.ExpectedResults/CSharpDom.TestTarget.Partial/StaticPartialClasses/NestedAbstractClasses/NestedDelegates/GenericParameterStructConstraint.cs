namespace CSharpDom.TestTarget.Partial.StaticPartialClasses.NestedAbstractClasses.NestedDelegates
{
    public static partial class StaticPartialClassWithNestedAbstractClassWithNestedDelegateWithGenericParameterStructConstraint
    {
        public abstract class Class
        {
            public delegate void DelegateWithGenericParameterStructConstraint<T>()
                where T : struct;
        }
    }
}
