namespace CSharpDom.TestTarget.Partial.PartialClasses.NestedClasses.NestedDelegates
{
    public partial class PartialClassWithNestedClassWithNestedDelegateWithGenericParameterStructConstraint
    {
        public class Class
        {
            public delegate void DelegateWithGenericParameterStructConstraint<T>()
                where T : struct;
        }
    }
}
