namespace CSharpDom.TestTarget.Partial.Classes.NestedPartialClasses.Methods
{
    public class ClassWithNestedPartialClassWithMethodWithGenericParameterClassConstraint
    {
        public partial class Class
        {
            public T Method<T>()
                where T : class
            {
                return default(T);
            }
        }
    }
}
