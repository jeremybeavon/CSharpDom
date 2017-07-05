namespace CSharpDom.TestTarget.Partial.Classes.NestedClasses
{
    public class ClassWithNestedPartialClassWithGenericParameterBaseClassConstraint
    {
        public class Class<T>
            where T : BaseClass
        {
        }
    }
}
