namespace CSharpDom.TestTarget.Partial.AbstractClasses.NestedPartialClasses.NestedAbstractClasses
{
    public abstract class AbstractClassWithNestedPartialClassWithNestedAbstractPartialClassWithGenericParameterClassAndEmptyConstructorConstraints
    {
        public partial class Class
        {
            public abstract class NestedClass<T>
                where T : class, new()
            {
            }
        }
    }
}
