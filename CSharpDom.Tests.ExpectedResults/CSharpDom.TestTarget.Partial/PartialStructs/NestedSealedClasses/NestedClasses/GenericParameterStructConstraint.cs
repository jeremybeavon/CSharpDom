namespace CSharpDom.TestTarget.Partial.PartialStructs.NestedSealedClasses.NestedClasses
{
    public partial struct PartialStructWithWithNestedSealedClassWithNestedClassWithGenericParameterStructConstraint
    {
        public sealed class Class
        {
            public class NestedClass<T>
                where T : struct
            {
            }
        }
    }
}
