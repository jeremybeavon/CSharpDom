namespace CSharpDom.TestTarget.SealedClasses.NestedSealedClasses.NestedDelegates
{
    public sealed class SealedClassWithNestedSealedClassWithNestedDelegateWithGenericParameterStructConstraint
    {
        public sealed class Class
        {
            public delegate void DelegateWithGenericParameterStructConstraint<T>()
                where T : struct;
        }
    }
}
