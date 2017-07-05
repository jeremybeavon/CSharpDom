namespace CSharpDom.TestTarget.Partial.Classes.NestedSealedPartialClasses.NestedAbstractClasses
{
    public class ClassWithNestedSealedPartialClassWithNestedAbstractPartialClassWithGenericParameterClassConstraint
    {
        public sealed partial class Class
        {
            public abstract class NestedClass<T>
                where T : class
            {
            }
        }
    }
}
