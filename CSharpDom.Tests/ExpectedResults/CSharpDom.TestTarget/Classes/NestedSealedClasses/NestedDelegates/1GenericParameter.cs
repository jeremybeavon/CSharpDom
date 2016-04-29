namespace CSharpDom.TestTarget.Classes.NestedSealedClasses.NestedDelegates
{
    public class ClassWithNestedSealedClassWithNestedDelegateWith1GenericParameter
    {
        public sealed class Class
        {
            public delegate void DelegateWith1GenericParameter<T>();
        }
    }
}
