namespace CSharpDom.TestTarget.Partial.AbstractClasses.NestedPartialClasses.Methods
{
    public abstract class AbstractClassWithNestedPartialClassWithMethodWithGenericParameterBaseClassConstraint
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
