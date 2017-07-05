namespace CSharpDom.TestTarget.Partial.PartialClasses.NestedClasses.NestedClasses
{
    public partial class PartialClassWithNestedClassWithNestedClassWithGenericParameterStructConstraint
    {
        public class Class
        {
            public class NestedClass<T>
                where T : struct
            {
            }
        }
    }
}
