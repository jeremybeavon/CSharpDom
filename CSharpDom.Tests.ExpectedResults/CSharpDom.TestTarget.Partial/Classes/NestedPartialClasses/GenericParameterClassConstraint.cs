namespace CSharpDom.TestTarget.Partial.Classes.NestedClasses
{
    public class ClassWithNestedPartialClassWithGenericParameterClassConstraint
    {
        public class Class<T>
            where T : class
        {
        }
    }
}
