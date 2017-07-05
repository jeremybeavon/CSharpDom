namespace CSharpDom.TestTarget.Partial.PartialClasses.NestedClasses.NestedSealedClasses
{
    public partial class PartialClassWithNestedClassWithNestedSealedClassWithGenericParameterClassConstraint
    {
        public class Class
        {
            public sealed class NestedClass<T>
                where T : class
            {
            }
        }
    }
}
