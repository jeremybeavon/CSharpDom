namespace CSharpDom.TestTarget.Partial.AbstractPartialClasses.NestedClasses.NestedAbstractClasses
{
    public abstract partial class AbstractPartialClassWithNestedClassWithNestedAbstractClassWithGenericParameterBaseClassConstraint
    {
        public class Class
        {
            public abstract class NestedClass<T>
                where T : BaseClass
            {
            }
        }
    }
}
