namespace CSharpDom.TestTarget.Partial.SealedClasses.NestedAbstractPartialClasses.NestedClasses
{
    public sealed class SealedClassWithNestedAbstractPartialClassWithNestedPartialClassWithGenericParameterStructConstraint
    {
        public abstract partial class Class
        {
            public class NestedClass<T>
                where T : struct
            {
            }
        }
    }
}
