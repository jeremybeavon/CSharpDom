namespace CSharpDom.TestTarget.Partial.AbstractClasses.NestedPartialClasses.NestedClasses
{
    public abstract class AbstractClassWithNestedPartialClassWithNestedPartialClassWithGenericParameterEmptyConstructorConstraint
    {
        public partial class Class
        {
            public class NestedClass<T>
                where T : new()
            {
            }
        }
    }
}
