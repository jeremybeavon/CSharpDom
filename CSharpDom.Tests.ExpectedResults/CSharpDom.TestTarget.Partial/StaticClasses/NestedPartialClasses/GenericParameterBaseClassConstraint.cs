namespace CSharpDom.TestTarget.Partial.StaticClasses.NestedClasses
{
    public static class StaticClassWithNestedPartialClassWithGenericParameterBaseClassConstraint
    {
        public class Class<T>
            where T : BaseClass
        {
        }
    }
}
