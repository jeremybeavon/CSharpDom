namespace CSharpDom.TestTarget.Partial.AbstractPartialClasses.NestedClasses.NestedStructs
{
    public abstract partial class AbstractPartialClassWithNestedClassWithNestedStructWithGenericParameterClassConstraint
    {
        public class Class
        {
            public struct NestedStruct<T>
                where T : class
            {
            }
        }
    }
}
