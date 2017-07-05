namespace CSharpDom.TestTarget.Partial.PartialClasses.NestedAbstractClasses.NestedClasses
{
    public partial class PartialClassWithNestedAbstractClassWithNestedClassWithGenericParameterClassConstraint
    {
        public abstract class Class
        {
            public class NestedClass<T>
                where T : class
            {
            }
        }
    }
}
