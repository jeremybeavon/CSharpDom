namespace CSharpDom.TestTarget.Partial.AbstractClasses.NestedAbstractPartialClasses.NestedSealedClasses
{
    public abstract class AbstractClassWithNestedAbstractPartialClassWithNestedSealedPartialClassWithGenericParameterStructConstraint
    {
        public abstract partial class Class
        {
            public sealed class NestedClass<T>
                where T : struct
            {
            }
        }
    }
}
