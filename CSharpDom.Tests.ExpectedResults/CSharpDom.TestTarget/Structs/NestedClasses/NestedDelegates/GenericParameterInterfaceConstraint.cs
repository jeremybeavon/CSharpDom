namespace CSharpDom.TestTarget.Structs.NestedClasses.NestedDelegates
{
    public struct StructWithNestedClassWithNestedDelegateWithGenericParameterInterfaceConstraint
    {
        public class Class
        {
            public delegate void DelegateWithGenericParameterInterfaceConstraint<T>()
                where T : IInterface;
        }
    }
}
