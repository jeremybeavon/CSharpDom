namespace CSharpDom.TestTarget.Classes.NestedSealedClasses.NestedDelegates
{
    public class ClassWithNestedSealedClassWithNestedDelegateWithGenericParameterClassAndEmptyConstructorConstraints
    {
        public sealed class Class
        {
            public delegate void DelegateWithGenericParameterClassAndEmptyConstructorConstraints<T>()
                where T : class, new();
        }
    }
}
