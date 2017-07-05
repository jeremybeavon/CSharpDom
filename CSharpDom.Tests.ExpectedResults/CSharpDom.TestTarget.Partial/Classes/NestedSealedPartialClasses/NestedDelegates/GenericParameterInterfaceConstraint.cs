namespace CSharpDom.TestTarget.Partial.Classes.NestedSealedPartialClasses.NestedDelegates
{
    public class ClassWithNestedSealedPartialClassWithNestedDelegateWithGenericParameterInterfaceConstraint
    {
        public sealed partial class Class
        {
            public delegate void DelegateWithGenericParameterInterfaceConstraint<T>()
                where T : IInterface;
        }
    }
}
