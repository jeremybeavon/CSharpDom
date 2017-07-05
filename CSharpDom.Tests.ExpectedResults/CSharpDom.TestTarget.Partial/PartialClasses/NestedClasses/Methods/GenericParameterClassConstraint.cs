namespace CSharpDom.TestTarget.Partial.PartialClasses.NestedClasses.Methods
{
    public partial class PartialClassWithNestedClassWithMethodWithGenericParameterClassConstraint
    {
        public class Class
        {
            public T Method<T>()
                where T : class
            {
                return default(T);
            }
        }
    }
}
