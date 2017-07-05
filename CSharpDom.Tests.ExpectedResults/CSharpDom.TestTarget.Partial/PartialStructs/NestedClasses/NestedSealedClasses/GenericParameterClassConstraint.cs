namespace CSharpDom.TestTarget.Partial.PartialStructs.NestedClasses.NestedSealedClasses
{
    public partial struct PartialStructWithWithNestedClassWithNestedSealedClassWithGenericParameterClassConstraint
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
