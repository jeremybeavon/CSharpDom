namespace CSharpDom.TestTarget.Partial.Classes.NestedSealedPartialClasses.NestedAbstractClasses
{
    public class ClassWithNestedSealedPartialClassWithNestedAbstractPartialClassWithGenericParameterEmptyConstructorConstraint
    {
        public sealed partial class Class
        {
            public abstract class NestedClass<T>
                where T : new()
            {
            }
        }
    }
}
