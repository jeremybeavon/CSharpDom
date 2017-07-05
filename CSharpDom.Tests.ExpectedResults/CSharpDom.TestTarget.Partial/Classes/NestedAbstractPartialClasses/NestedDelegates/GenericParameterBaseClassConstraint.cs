namespace CSharpDom.TestTarget.Partial.Classes.NestedAbstractPartialClasses.NestedDelegates
{
    public class ClassWithNestedAbstractPartialClassWithNestedDelegateWithGenericParameterBaseClassConstraint
    {
        public abstract partial class Class
        {
            public delegate void DelegateWithGenericParameterBaseClassConstraint<T>()
                where T : BaseClass;
        }
    }
}
