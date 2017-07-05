namespace CSharpDom.TestTarget.Partial.PartialStructs.NestedClasses.NestedDelegates
{
    public partial struct PartialStructWithWithNestedClassWithNestedDelegateWithGenericParameterBaseClassConstraint
    {
        public class Class
        {
            public delegate void DelegateWithGenericParameterBaseClassConstraint<T>()
                where T : BaseClass;
        }
    }
}
