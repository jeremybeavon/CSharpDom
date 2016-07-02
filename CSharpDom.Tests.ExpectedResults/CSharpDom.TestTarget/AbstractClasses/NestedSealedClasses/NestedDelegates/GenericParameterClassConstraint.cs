namespace CSharpDom.TestTarget.AbstractClasses.NestedSealedClasses.NestedDelegates
{
    public abstract class AbstractClassWithNestedSealedClassWithNestedClassWithNestedDelegateWithGenericParameterClassConstraint
    {
        public sealed class Class
        {
            public delegate void DelegateWithGenericParameterClassConstraint<T>()
                where T : class;
        }
    }
}
