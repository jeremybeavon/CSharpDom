namespace CSharpDom.TestTarget.Partial.PartialClasses.NestedClasses.NestedSealedClasses
{
    public partial class PartialClassWithNestedClassWithNestedSealedClassWithGenericParameterBaseClassConstraint
    {
        public class Class
        {
            public sealed class NestedClass<T>
                where T : BaseClass
            {
            }
        }
    }
}
