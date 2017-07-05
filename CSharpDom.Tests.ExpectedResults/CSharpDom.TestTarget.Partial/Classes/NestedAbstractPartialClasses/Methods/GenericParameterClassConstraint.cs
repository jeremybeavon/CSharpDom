namespace CSharpDom.TestTarget.Partial.Classes.NestedAbstractPartialClasses.Methods
{
    public class ClassWithNestedAbstractPartialClassWithMethodWithGenericParameterClassConstraint
    {
        public abstract partial class Class
        {
            public T Method<T>()
                where T : class
            {
                return default(T);
            }
        }
    }
}
