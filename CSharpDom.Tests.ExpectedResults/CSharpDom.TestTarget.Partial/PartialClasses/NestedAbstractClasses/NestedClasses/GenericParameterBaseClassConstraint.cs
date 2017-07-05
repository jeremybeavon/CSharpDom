namespace CSharpDom.TestTarget.Partial.PartialClasses.NestedAbstractClasses.NestedClasses
{
    public partial class PartialClassWithNestedAbstractClassWithNestedClassWithGenericParameterBaseClassConstraint
    {
        public abstract class Class
        {
            public class NestedClass<T>
                where T : BaseClass
            {
            }
        }
    }
}
