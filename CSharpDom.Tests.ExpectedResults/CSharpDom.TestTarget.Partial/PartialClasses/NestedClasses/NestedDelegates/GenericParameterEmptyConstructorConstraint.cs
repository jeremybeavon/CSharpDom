namespace CSharpDom.TestTarget.Partial.PartialClasses.NestedClasses.NestedDelegates
{
    public partial class PartialClassWithNestedClassWithNestedDelegateWithGenericParameterEmptyConstructorConstraint
    {
        public class Class
        {
            public delegate void DelegateWithGenericParameterEmptyConstructorConstraint<T>()
                where T : new();
        }
    }
}
