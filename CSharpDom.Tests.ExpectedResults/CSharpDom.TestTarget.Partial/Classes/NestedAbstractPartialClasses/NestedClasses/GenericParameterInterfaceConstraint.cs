namespace CSharpDom.TestTarget.Partial.Classes.NestedAbstractPartialClasses.NestedClasses
{
    public class ClassWithNestedAbstractPartialClassWithNestedPartialClassWithGenericParameterInterfaceConstraint
    {
        public abstract partial class Class
        {
            public class NestedClass<T>
                where T : IInterface
            {
            }
        }
    }
}
