namespace CSharpDom.TestTarget.Partial.PartialClasses.NestedClasses.NestedAbstractClasses
{
    public partial class PartialClassWithNestedClassWithNestedAbstractClassWithGenericParameterClassConstraint
    {
        public class Class
        {
            public abstract class NestedClass<T>
                where T : class
            {
            }
        }
    }
}
