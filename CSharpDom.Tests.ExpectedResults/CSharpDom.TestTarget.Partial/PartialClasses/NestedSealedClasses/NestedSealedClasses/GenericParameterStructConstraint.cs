namespace CSharpDom.TestTarget.Partial.PartialClasses.NestedSealedClasses.NestedSealedClasses
{
    public partial class PartialClassWithNestedSealedClassWithNestedSealedClassWithGenericParameterStructConstraint
    {
        public sealed class Class
        {
            public sealed class NestedClass<T>
                where T : struct
            {
            }
        }
    }
}
