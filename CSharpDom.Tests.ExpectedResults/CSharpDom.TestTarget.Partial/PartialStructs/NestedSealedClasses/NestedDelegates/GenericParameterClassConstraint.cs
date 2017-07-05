namespace CSharpDom.TestTarget.Partial.PartialStructs.NestedSealedClasses.NestedDelegates
{
    public partial struct PartialStructWithWithNestedSealedClassWithNestedDelegateWithGenericParameterClassConstraint
    {
        public sealed class Class
        {
            public delegate void DelegateWithGenericParameterClassConstraint<T>()
                where T : class;
        }
    }
}
