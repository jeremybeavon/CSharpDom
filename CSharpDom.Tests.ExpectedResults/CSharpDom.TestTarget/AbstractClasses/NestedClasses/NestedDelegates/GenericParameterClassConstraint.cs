namespace CSharpDom.TestTarget.AbstractClasses.NestedClasses.NestedDelegates
{
    public abstract class AbstractClassWithNestedClassWithNestedClassWithNestedDelegateWithGenericParameterClassConstraint
    {
        public class Class
        {
            public delegate void DelegateWithGenericParameterClassConstraint<T>()
                where T : class;
        }
    }
}
