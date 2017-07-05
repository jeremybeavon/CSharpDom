namespace CSharpDom.TestTarget.Partial.Classes.NestedStructs.NestedAbstractClasses
{
    public class ClassWithNestedStructWithNestedAbstractPartialClassWithGenericParameterBaseClassConstraint
    {
        public struct Struct
        {
            public abstract class NestedClass<T>
                where T : BaseClass
            {
            }
        }
    }
}
