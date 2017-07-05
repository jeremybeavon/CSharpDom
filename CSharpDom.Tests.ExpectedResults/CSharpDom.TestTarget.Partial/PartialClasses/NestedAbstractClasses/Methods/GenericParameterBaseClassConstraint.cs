namespace CSharpDom.TestTarget.Partial.PartialClasses.NestedAbstractClasses.Methods
{
    public partial class PartialClassWithNestedAbstractClassWithMethodWithGenericParameterBaseClassConstraint
    {
        public abstract class Class
        {
            public T Method<T>()
                where T : BaseClass
            {
                return default(T);
            }
        }
    }
}
