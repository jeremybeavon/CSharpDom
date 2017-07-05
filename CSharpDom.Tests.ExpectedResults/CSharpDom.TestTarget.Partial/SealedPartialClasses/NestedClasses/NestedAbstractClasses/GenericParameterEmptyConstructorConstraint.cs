namespace CSharpDom.TestTarget.Partial.SealedPartialClasses.NestedClasses.NestedAbstractClasses
{
    public sealed partial class SealedPartialClassWithNestedClassWithNestedAbstractClassWithGenericParameterEmptyConstructorConstraint
    {
        public class Class
        {
            public abstract class NestedClass<T>
                where T : new()
            {
            }
        }
    }
}
