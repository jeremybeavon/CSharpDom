namespace CSharpDom.TestTarget.AbstractClasses.NestedSealedClasses.NestedDelegates
{
    public abstract class AbstractClassWithNestedSealedClassWithNestedDelegateWithGenericParameterEmptyConstructorConstraint
    {
        public sealed class Class
        {
            public delegate void DelegateWithGenericParameterEmptyConstructorConstraint<T>()
                where T : new();
        }
    }
}
