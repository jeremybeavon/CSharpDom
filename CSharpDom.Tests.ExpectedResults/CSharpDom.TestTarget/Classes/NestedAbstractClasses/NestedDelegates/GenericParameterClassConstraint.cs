namespace CSharpDom.TestTarget.Classes.NestedAbstractClasses.NestedDelegates
{
    public class ClassWithNestedAbstractClassWithNestedClassWithNestedDelegateWithGenericParameterClassConstraint
    {
        public abstract class Class
        {
            public delegate void DelegateWithGenericParameterClassConstraint<T>()
                where T : class;
        }
    }
}
