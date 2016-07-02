namespace CSharpDom.TestTarget.AbstractClasses.NestedClasses.NestedDelegates
{
    public abstract class AbstractClassWithNestedClassWithNestedDelegateWithGenericParameterStructConstraint
    {
        public class Class
        {
            public delegate void DelegateWithGenericParameterStructConstraint<T>()
                where T : struct;
        }
    }
}
