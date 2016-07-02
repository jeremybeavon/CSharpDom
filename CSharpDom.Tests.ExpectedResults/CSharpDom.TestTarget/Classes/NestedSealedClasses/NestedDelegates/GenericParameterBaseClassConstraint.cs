namespace CSharpDom.TestTarget.Classes.NestedSealedClasses.NestedDelegates
{
    public class ClassWithNestedSealedClassWithNestedDelegateWithGenericParameterBaseClassConstraint
    {
        public sealed class Class
        {
            public delegate void DelegateWithGenericParameterBaseClassConstraint<T>()
                where T : BaseClass;
        }
    }
}
