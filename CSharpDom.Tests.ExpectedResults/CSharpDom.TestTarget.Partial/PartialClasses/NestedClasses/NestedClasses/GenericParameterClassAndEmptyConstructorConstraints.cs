namespace CSharpDom.TestTarget.Partial.PartialClasses.NestedClasses.NestedClasses
{
    public partial class PartialClassWithNestedClassWithNestedClassWithGenericParameterClassAndEmptyConstructorConstraints
    {
        public class Class
        {
            public class NestedClass<T>
                where T : class, new()
            {
            }
        }
    }
}
