namespace CSharpDom.TestTarget.Partial.Classes.NestedStructs.NestedDelegates
{
    public class ClassWithNestedStructWithNestedDelegateWithGenericParameterInterfaceConstraint
    {
        public struct Struct
        {
            public delegate void DelegateWithGenericParameterInterfaceConstraint<T>()
                where T : IInterface;
        }
    }
}
