namespace CSharpDom.TestTarget.Partial.Classes.NestedStaticPartialClasses.NestedClasses
{
    public class ClassWithNestedStaticPartialClassWithNestedPartialClassWithGenericParameterInterfaceConstraint
    {
        public static partial class Class
        {
            public class NestedClass<T>
                where T : IInterface
            {
            }
        }
    }
}
