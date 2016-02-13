namespace CSharpDom.TestTarget.Classes.Methods
{
    public class ClassWithMethodWithGenericParameterBaseClassConstraint
    {
        public T Method<T>()
            where T : BaseClass
        {
            return default(T);
        }
    }
}
