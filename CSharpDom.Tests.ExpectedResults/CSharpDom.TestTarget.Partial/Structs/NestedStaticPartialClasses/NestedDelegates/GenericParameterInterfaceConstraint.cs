namespace CSharpDom.TestTarget.Partial.Structs.NestedStaticPartialClasses.NestedDelegates
{
    public struct StructWithNestedStaticPartialClassWithNestedDelegateWithGenericParameterInterfaceConstraint
    {
        public static partial class Class
        {
            public delegate void DelegateWithGenericParameterInterfaceConstraint<T>()
                where T : IInterface;
        }
    }
}
