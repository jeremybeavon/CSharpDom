namespace CSharpDom.TestTarget.Partial.PartialStructs.NestedClasses.NestedDelegates
{
    public partial struct PartialStructWithWithNestedClassWithNestedDelegateWithGenericParameterInterfaceConstraint
    {
        public class Class
        {
            public delegate void DelegateWithGenericParameterInterfaceConstraint<T>()
                where T : IInterface;
        }
    }
}
