namespace CSharpDom.TestTarget.Partial.AbstractClasses.NestedClasses
{
    public abstract class AbstractClassWithNestedPartialClassWithGenericParameterBaseClassConstraint
    {
        public class Class<T>
            where T : BaseClass
        {
        }
    }
}
