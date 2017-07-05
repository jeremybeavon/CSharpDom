namespace CSharpDom.TestTarget.Partial.Classes.NestedSealedPartialClasses.NestedSealedClasses
{
    public class ClassWithNestedSealedPartialClassWithNestedSealedPartialClassWithGenericParameterBaseClassConstraint
    {
        public sealed partial class Class
        {
            public sealed class NestedClass<T>
                where T : BaseClass
            {
            }
        }
    }
}
