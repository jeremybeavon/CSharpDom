namespace CSharpDom.TestTarget.Partial.PartialClasses.NestedSealedClasses.NestedClasses
{
    public partial class PartialClassWithNestedSealedClassWithNestedClassWithGenericParameterBaseClassConstraint
    {
        public sealed class Class
        {
            public class NestedClass<T>
                where T : BaseClass
            {
            }
        }
    }
}
