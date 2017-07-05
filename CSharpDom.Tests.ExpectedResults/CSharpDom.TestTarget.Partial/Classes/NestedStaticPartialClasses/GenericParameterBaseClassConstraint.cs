namespace CSharpDom.TestTarget.Partial.Classes.NestedStaticClasses
{
    public class ClassWithNestedStaticPartialClassWithGenericParameterBaseClassConstraint
    {
        public static class Class<T>
            where T : BaseClass
        {
        }
    }
}
