namespace CSharpDom.TestTarget.Partial.Classes.NestedSealedClasses
{
    public class ClassWithNestedSealedPartialClassWithGenericParameterBaseClassConstraint
    {
        public sealed class Class<T>
            where T : BaseClass
        {
        }
    }
}
