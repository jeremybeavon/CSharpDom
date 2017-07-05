namespace CSharpDom.TestTarget.Partial.PartialClasses.NestedSealedClasses.NestedClasses
{
    public partial class PartialClassWithNestedSealedClassWithNestedClassWithGenericParameterClassConstraint
    {
        public sealed class Class
        {
            public class NestedClass<T>
                where T : class
            {
            }
        }
    }
}
