namespace CSharpDom.TestTarget.Partial.PartialStructs.NestedClasses.NestedDelegates
{
    public partial struct PartialStructWithWithNestedClassWithNestedDelegateWithGenericParameterStructConstraint
    {
        public class Class
        {
            public delegate void DelegateWithGenericParameterStructConstraint<T>()
                where T : struct;
        }
    }
}
