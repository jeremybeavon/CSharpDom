namespace CSharpDom.TestTarget.Partial.PartialClasses.NestedClasses
{
    public partial class PartialClassWithNestedClassWithGenericParameterClassAndEmptyConstructorConstraints
    {
        public class Class<T>
            where T : class, new()
        {
        }
    }
}
