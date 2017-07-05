namespace CSharpDom.TestTarget.Partial.PartialClasses.NestedAbstractClasses.NestedAbstractClasses
{
    public partial class PartialClassWithNestedAbstractClassWithNestedAbstractClassWithGenericParameterBaseClassConstraint
    {
        public abstract class Class
        {
            public abstract class NestedClass<T>
                where T : BaseClass
            {
            }
        }
    }
}
