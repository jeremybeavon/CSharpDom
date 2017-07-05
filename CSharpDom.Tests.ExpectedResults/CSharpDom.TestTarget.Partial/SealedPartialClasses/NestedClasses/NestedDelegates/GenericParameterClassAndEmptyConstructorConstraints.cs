namespace CSharpDom.TestTarget.Partial.SealedPartialClasses.NestedClasses.NestedDelegates
{
    public sealed partial class SealedPartialClassWithNestedClassWithNestedDelegateWithGenericParameterClassAndEmptyConstructorConstraints
    {
        public class Class
        {
            public delegate void DelegateWithGenericParameterClassAndEmptyConstructorConstraints<T>()
                where T : class, new();
        }
    }
}
