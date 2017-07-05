namespace CSharpDom.TestTarget.Partial.PartialClasses.NestedClasses.NestedAbstractClasses
{
    public partial class PartialClassWithNestedClassWithNestedAbstractClassWithGenericParameterEmptyConstructorConstraint
    {
        public class Class
        {
            public abstract class NestedClass<T>
                where T : new()
            {
            }
        }
    }
}
