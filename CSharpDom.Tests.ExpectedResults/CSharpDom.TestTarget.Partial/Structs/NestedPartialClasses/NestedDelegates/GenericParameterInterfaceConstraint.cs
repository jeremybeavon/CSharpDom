namespace CSharpDom.TestTarget.Partial.Structs.NestedPartialClasses.NestedDelegates
{
    public struct StructWithNestedPartialClassWithNestedDelegateWithGenericParameterInterfaceConstraint
    {
        public partial class Class
        {
            public delegate void DelegateWithGenericParameterInterfaceConstraint<T>()
                where T : IInterface;
        }
    }
}
