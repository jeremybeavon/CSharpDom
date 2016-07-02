namespace CSharpDom.TestTarget.Classes.NestedClasses.NestedDelegates
{
    public class ClassWithNestedClassWithNestedDelegateWithGenericParameterBaseClassConstraint
    {
        public class Class
        {
            public delegate void DelegateWithGenericParameterBaseClassConstraint<T>()
                where T : BaseClass;
        }
    }
}
