namespace CSharpDom.TestTarget.Partial.PartialStructs.NestedSealedClasses.NestedDelegates
{
    public partial struct PartialStructWithWithNestedSealedClassWithNestedDelegateWithGenericParameterStructConstraint
    {
        public sealed class Class
        {
            public delegate void DelegateWithGenericParameterStructConstraint<T>()
                where T : struct;
        }
    }
}
