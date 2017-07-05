namespace CSharpDom.TestTarget.Partial.PartialClasses.NestedClasses.NestedDelegates
{
    public partial class PartialClassWithNestedClassWithNestedDelegateWithGenericParameterGenericParameterConstraint
    {
        public class Class
        {
            public delegate void DelegateWithGenericParameterGenericParameterConstraint<TKey, TValue>()
                where TKey : TValue;
        }
    }
}
