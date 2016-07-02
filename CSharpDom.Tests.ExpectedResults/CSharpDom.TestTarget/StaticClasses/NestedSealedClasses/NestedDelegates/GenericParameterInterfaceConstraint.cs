namespace CSharpDom.TestTarget.StaticClasses.NestedSealedClasses.NestedDelegates
{
    public static class StaticClassWithNestedSealedClassWithNestedDelegateWithGenericParameterInterfaceConstraint
    {
        public sealed class Class
        {
            public delegate void DelegateWithGenericParameterInterfaceConstraint<T>()
                where T : IInterface;
        }
    }
}
