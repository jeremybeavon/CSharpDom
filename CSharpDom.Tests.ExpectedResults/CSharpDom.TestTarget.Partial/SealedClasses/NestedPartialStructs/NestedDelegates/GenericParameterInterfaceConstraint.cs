namespace CSharpDom.TestTarget.Partial.SealedClasses.NestedStructs.NestedDelegates
{
    public sealed class SealedClassWithNestedStructWithNestedDelegateWithGenericParameterInterfaceConstraint
    {
        public struct Struct
        {
            public delegate void DelegateWithGenericParameterInterfaceConstraint<T>()
                where T : IInterface;
        }
    }
}
