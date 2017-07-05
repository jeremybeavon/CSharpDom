namespace CSharpDom.TestTarget.Partial.StaticPartialClasses.NestedClasses.NestedClasses
{
    public static partial class StaticPartialClassWithNestedClassWithNestedClassWithGenericParameterBaseClassConstraint
    {
        public class Class
        {
            public class NestedClass<T>
                where T : BaseClass
            {
            }
        }
    }
}
