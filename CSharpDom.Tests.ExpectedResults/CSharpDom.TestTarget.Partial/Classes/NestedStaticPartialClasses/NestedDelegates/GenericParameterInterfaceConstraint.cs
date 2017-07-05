namespace CSharpDom.TestTarget.Partial.Classes.NestedStaticPartialClasses.NestedDelegates
{
    public class ClassWithNestedStaticPartialClassWithNestedDelegateWithGenericParameterInterfaceConstraint
    {
        public static partial class Class
        {
            public delegate void DelegateWithGenericParameterInterfaceConstraint<T>()
                where T : IInterface;
        }
    }
}
