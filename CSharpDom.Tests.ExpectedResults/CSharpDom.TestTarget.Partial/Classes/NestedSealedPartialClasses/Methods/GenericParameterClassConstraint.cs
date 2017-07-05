namespace CSharpDom.TestTarget.Partial.Classes.NestedSealedPartialClasses.Methods
{
    public class ClassWithNestedSealedPartialClassWithMethodWithGenericParameterClassConstraint
    {
        public sealed partial class Class
        {
            public T Method<T>()
                where T : class
            {
                return default(T);
            }
        }
    }
}
