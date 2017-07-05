namespace CSharpDom.TestTarget.Partial.Classes.NestedClasses
{
    public class ClassWithNestedPartialClassWithGenericParameterStructConstraint
    {
        public class Class<T>
            where T : struct
        {
        }
    }
}
