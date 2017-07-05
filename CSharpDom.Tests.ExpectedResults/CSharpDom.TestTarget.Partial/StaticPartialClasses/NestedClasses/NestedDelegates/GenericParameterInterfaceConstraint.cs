namespace CSharpDom.TestTarget.Partial.StaticPartialClasses.NestedClasses.NestedDelegates
{
    public static partial class StaticPartialClassWithNestedClassWithNestedDelegateWithGenericParameterInterfaceConstraint
    {
        public class Class
        {
            public delegate void DelegateWithGenericParameterInterfaceConstraint<T>()
                where T : IInterface;
        }
    }
}
