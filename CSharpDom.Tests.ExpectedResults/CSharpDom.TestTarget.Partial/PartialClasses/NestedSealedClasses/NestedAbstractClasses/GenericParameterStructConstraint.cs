namespace CSharpDom.TestTarget.Partial.PartialClasses.NestedSealedClasses.NestedAbstractClasses
{
    public partial class PartialClassWithNestedSealedClassWithNestedAbstractClassWithGenericParameterStructConstraint
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
