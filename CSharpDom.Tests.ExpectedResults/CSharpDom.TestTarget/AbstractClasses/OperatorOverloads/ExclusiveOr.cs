namespace CSharpDom.TestTarget.AbstractClasses.OperatorOverloads
{
    public abstract class AbstractClassWithExclusiveOrOperatorOverload
    {
        public static AbstractClassWithExclusiveOrOperatorOverload operator ^(AbstractClassWithExclusiveOrOperatorOverload parameter1, AbstractClassWithExclusiveOrOperatorOverload parameter2)
        {
            return default(AbstractClassWithExclusiveOrOperatorOverload);
        }
    }
}
