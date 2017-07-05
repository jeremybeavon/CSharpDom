namespace CSharpDom.TestTarget.Partial.StaticPartialClasses.NestedClasses.NestedAbstractClasses
{
    public static partial class StaticPartialClassWithNestedClassWithNestedAbstractClassWithGenericParameterBaseClassConstraint
    {
        public class Class
        {
            public abstract class NestedClass<T>
                where T : BaseClass
            {
            }
        }
    }
}
