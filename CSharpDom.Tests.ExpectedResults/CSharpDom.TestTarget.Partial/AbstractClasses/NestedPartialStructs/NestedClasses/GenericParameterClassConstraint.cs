namespace CSharpDom.TestTarget.Partial.AbstractClasses.NestedStructs.NestedClasses
{
    public abstract class AbstractClassWithNestedStructWithNestedPartialClassWithGenericParameterClassConstraint
    {
        public struct Struct
        {
            public class NestedClass<T>
                where T : class
            {
            }
        }
    }
}
