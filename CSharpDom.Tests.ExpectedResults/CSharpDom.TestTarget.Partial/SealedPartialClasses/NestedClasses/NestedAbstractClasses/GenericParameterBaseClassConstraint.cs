namespace CSharpDom.TestTarget.Partial.SealedPartialClasses.NestedClasses.NestedAbstractClasses
{
    public sealed partial class SealedPartialClassWithNestedClassWithNestedAbstractClassWithGenericParameterBaseClassConstraint
    {
        public class Class
        {
            public abstract class NestedClass<T>
                where T : BaseClass
            {
            }
        }
    }
}
