namespace CSharpDom.TestTarget.Partial.Classes.NestedClasses
{
    public class ClassWithNestedPartialClassWithGenericParameterInterfaceConstraint
    {
        public class Class<T>
            where T : IInterface
        {
        }
    }
}
