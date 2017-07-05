namespace CSharpDom.TestTarget.Partial.PartialClasses.NestedAbstractClasses.NestedAbstractClasses
{
    public partial class PartialClassWithNestedAbstractClassWithNestedAbstractClassWithGenericParameterClassAndEmptyConstructorConstraints
    {
        public abstract class Class
        {
            public abstract class NestedClass<T>
                where T : class, new()
            {
            }
        }
    }
}
