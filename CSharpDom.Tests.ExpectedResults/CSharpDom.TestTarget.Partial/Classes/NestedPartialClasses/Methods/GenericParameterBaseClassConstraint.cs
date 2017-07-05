namespace CSharpDom.TestTarget.Partial.Classes.NestedPartialClasses.Methods
{
    public class ClassWithNestedPartialClassWithMethodWithGenericParameterBaseClassConstraint
    {
        public partial class Class
        {
            public T Method<T>()
                where T : BaseClass
            {
                return default(T);
            }
        }
    }
}
