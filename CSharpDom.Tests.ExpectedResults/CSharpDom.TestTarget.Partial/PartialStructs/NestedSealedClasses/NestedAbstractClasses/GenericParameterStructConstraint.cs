namespace CSharpDom.TestTarget.Partial.PartialStructs.NestedSealedClasses.NestedAbstractClasses
{
    public partial struct PartialStructWithWithNestedSealedClassWithNestedAbstractClassWithGenericParameterStructConstraint
    {
        public sealed class Class
        {
            public abstract class NestedClass<T>
                where T : struct
            {
            }
        }
    }
}
