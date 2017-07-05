namespace CSharpDom.TestTarget.Partial.PartialClasses.NestedClasses.NestedDelegates
{
    public partial class PartialClassWithNestedClassWithNestedDelegateWithGenericParameterClassAndEmptyConstructorConstraints
    {
        public class Class
        {
            public delegate void DelegateWithGenericParameterClassAndEmptyConstructorConstraints<T>()
                where T : class, new();
        }
    }
}
