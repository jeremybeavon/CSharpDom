namespace CSharpDom.TestTarget.Partial.Classes.NestedStaticPartialClasses.NestedDelegates
{
    public class ClassWithNestedStaticPartialClassWithNestedDelegateWithGenericParameterBaseClassConstraint
    {
        public static partial class Class
        {
            public delegate void DelegateWithGenericParameterBaseClassConstraint<T>()
                where T : BaseClass;
        }
    }
}
