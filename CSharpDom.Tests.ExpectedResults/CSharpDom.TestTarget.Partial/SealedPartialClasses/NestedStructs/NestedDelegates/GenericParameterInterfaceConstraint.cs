namespace CSharpDom.TestTarget.Partial.SealedPartialClasses.NestedStructs.NestedDelegates
{
    public sealed partial class SealedPartialClassWithNestedStructWithNestedDelegateWithGenericParameterInterfaceConstraint
    {
        public struct Struct
        {
            public delegate void DelegateWithGenericParameterInterfaceConstraint<T>()
                where T : IInterface;
        }
    }
}
