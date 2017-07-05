namespace CSharpDom.TestTarget.Partial.AbstractClasses.NestedAbstractPartialClasses.NestedClasses
{
    public abstract class AbstractClassWithNestedAbstractPartialClassWithNestedPartialClassWithGenericParameterEmptyConstructorConstraint
    {
        public abstract partial class Class
        {
            public class NestedClass<T>
                where T : new()
            {
            }
        }
    }
}
