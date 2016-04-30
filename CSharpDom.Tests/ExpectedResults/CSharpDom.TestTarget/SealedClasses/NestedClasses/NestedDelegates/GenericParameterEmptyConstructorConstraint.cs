namespace CSharpDom.TestTarget.SealedClasses.NestedClasses.NestedDelegates
{
    public sealed class SealedClassWithNestedClassWithNestedDelegateWithGenericParameterEmptyConstructorConstraint
    {
        public class Class
        {
            public delegate void DelegateWithGenericParameterEmptyConstructorConstraint<T>()
                where T : new();
        }
    }
}
