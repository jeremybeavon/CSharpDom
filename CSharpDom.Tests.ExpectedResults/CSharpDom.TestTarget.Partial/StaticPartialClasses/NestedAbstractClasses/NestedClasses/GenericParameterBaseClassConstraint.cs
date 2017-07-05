namespace CSharpDom.TestTarget.Partial.StaticPartialClasses.NestedAbstractClasses.NestedClasses
{
    public static partial class StaticPartialClassWithNestedAbstractClassWithNestedClassWithGenericParameterBaseClassConstraint
    {
        public abstract class Class
        {
            public class NestedClass<T>
                where T : BaseClass
            {
            }
        }
    }
}
