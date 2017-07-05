namespace CSharpDom.TestTarget.Partial.SealedPartialClasses.NestedAbstractClasses.NestedClasses
{
    public sealed partial class SealedPartialClassWithNestedAbstractClassWithNestedClassWithGenericParameterStructConstraint
    {
        public abstract class Class
        {
            public class NestedClass<T>
                where T : struct
            {
            }
        }
    }
}
