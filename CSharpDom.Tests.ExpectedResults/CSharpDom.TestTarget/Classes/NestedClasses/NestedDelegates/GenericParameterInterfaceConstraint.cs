namespace CSharpDom.TestTarget.Classes.NestedClasses.NestedDelegates
{
    public class ClassWithNestedClassWithNestedDelegateWithGenericParameterInterfaceConstraint
    {
        public class Class
        {
            public delegate void DelegateWithGenericParameterInterfaceConstraint<T>()
                where T : IInterface;
        }
    }
}
