namespace CSharpDom.TestTarget.Partial.StaticPartialClasses.NestedClasses
{
    public static partial class StaticPartialClassWithNestedClassWithGenericParameterBaseClassConstraint
    {
        public class Class<T>
            where T : BaseClass
        {
        }
    }
}
