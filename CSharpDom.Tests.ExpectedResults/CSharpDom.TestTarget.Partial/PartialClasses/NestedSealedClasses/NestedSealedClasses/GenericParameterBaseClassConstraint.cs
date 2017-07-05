namespace CSharpDom.TestTarget.Partial.PartialClasses.NestedSealedClasses.NestedSealedClasses
{
    public partial class PartialClassWithNestedSealedClassWithNestedSealedClassWithGenericParameterBaseClassConstraint
    {
        public sealed class Class
        {
            public sealed class NestedClass<T>
                where T : BaseClass
            {
            }
        }
    }
}
