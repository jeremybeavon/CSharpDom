namespace CSharpDom.TestTarget.Partial.SealedClasses.NestedAbstractPartialClasses.NestedAbstractClasses
{
    public sealed class SealedClassWithNestedAbstractPartialClassWithNestedAbstractPartialClassWithGenericParameterStructConstraint
    {
        public abstract partial class Class
        {
            public abstract class NestedClass<T>
                where T : struct
            {
            }
        }
    }
}
