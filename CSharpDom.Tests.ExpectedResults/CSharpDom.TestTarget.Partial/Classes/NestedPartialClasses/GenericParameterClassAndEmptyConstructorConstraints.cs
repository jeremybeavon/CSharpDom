namespace CSharpDom.TestTarget.Partial.Classes.NestedClasses
{
    public class ClassWithNestedPartialClassWithGenericParameterClassAndEmptyConstructorConstraints
    {
        public class Class<T>
            where T : class, new()
        {
        }
    }
}
