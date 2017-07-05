namespace CSharpDom.TestTarget.Partial.Classes.NestedStaticPartialClasses.NestedClasses
{
    public class ClassWithNestedStaticPartialClassWithNestedPartialClassWithGenericParameterBaseClassConstraint
    {
        public static partial class Class
        {
            public class NestedClass<T>
                where T : BaseClass
            {
            }
        }
    }
}
