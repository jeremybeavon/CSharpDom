namespace CSharpDom.TestTarget.Partial.Classes.NestedAbstractPartialClasses.Methods
{
    public class ClassWithNestedAbstractPartialClassWithMethodWithGenericParameterClassAndEmptyConstructorConstraints
    {
        public abstract partial class Class
        {
            public T Method<T>()
                where T : class, new()
            {
                return default(T);
            }
        }
    }
}
