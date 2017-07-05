namespace CSharpDom.TestTarget.Partial.PartialStructs.NestedClasses.NestedSealedClasses
{
    public partial struct PartialStructWithWithNestedClassWithNestedSealedClassWithGenericParameterBaseClassConstraint
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
