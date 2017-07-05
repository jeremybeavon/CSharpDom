namespace CSharpDom.TestTarget.Partial.Classes.NestedAbstractPartialClasses.NestedAbstractClasses
{
    public class ClassWithNestedAbstractPartialClassWithNestedAbstractPartialClassWithGenericParameterBaseClassConstraint
    {
        public abstract partial class Class
        {
            public abstract class NestedClass<T>
                where T : BaseClass
            {
            }
        }
    }
}
