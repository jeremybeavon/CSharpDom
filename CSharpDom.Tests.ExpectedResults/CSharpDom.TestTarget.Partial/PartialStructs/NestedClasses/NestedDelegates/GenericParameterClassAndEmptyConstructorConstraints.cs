namespace CSharpDom.TestTarget.Partial.PartialStructs.NestedClasses.NestedDelegates
{
    public partial struct PartialStructWithWithNestedClassWithNestedDelegateWithGenericParameterClassAndEmptyConstructorConstraints
    {
        public class Class
        {
            public delegate void DelegateWithGenericParameterClassAndEmptyConstructorConstraints<T>()
                where T : class, new();
        }
    }
}
