namespace CSharpDom.TestTarget.Classes.Methods
{
    public class ClassWithMethodWithGenericParameterInterfaceConstraint
    {
        public T Method<T>()
            where T : IInterface
        {
            return default(T);
        }
    }
}
