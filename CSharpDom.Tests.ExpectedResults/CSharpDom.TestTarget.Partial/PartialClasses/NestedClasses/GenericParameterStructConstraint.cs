namespace CSharpDom.TestTarget.Partial.PartialClasses.NestedClasses
{
    public partial class PartialClassWithNestedClassWithGenericParameterStructConstraint
    {
        public class Class<T>
            where T : struct
        {
        }
    }
}
