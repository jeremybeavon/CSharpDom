namespace CSharpDom.TestTarget.Partial.SealedPartialClasses.NestedClasses.NestedAbstractClasses
{
    public sealed partial class SealedPartialClassWithNestedClassWithNestedAbstractClassWithGenericParameterStructConstraint
    {
        public class Class
        {
            public abstract class NestedClass<T>
                where T : struct
            {
            }
        }
    }
}
