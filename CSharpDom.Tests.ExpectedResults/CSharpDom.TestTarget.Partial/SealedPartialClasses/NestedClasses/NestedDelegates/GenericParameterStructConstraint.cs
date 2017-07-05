namespace CSharpDom.TestTarget.Partial.SealedPartialClasses.NestedClasses.NestedDelegates
{
    public sealed partial class SealedPartialClassWithNestedClassWithNestedDelegateWithGenericParameterStructConstraint
    {
        public class Class
        {
            public delegate void DelegateWithGenericParameterStructConstraint<T>()
                where T : struct;
        }
    }
}
