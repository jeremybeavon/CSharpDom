namespace CSharpDom.TestTarget.Partial.SealedPartialClasses.NestedClasses.NestedDelegates
{
    public sealed partial class SealedPartialClassWithNestedClassWithNestedClassWithNestedDelegateWithGenericParameterClassConstraint
    {
        public class Class
        {
            public delegate void DelegateWithGenericParameterClassConstraint<T>()
                where T : class;
        }
    }
}
