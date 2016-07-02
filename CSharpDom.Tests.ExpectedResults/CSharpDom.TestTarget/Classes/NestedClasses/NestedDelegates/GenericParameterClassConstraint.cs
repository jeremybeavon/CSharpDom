namespace CSharpDom.TestTarget.Classes.NestedClasses.NestedDelegates
{
    public class ClassWithNestedClassWithNestedClassWithNestedDelegateWithGenericParameterClassConstraint
    {
        public class Class
        {
            public delegate void DelegateWithGenericParameterClassConstraint<T>()
                where T : class;
        }
    }
}
