namespace CSharpDom.TestTarget.Partial.PartialStructs.NestedClasses.NestedSealedClasses
{
    public partial struct PartialStructWithNestedClassWithNestedSealedClassWithGenericParameterClassConstraint
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
