namespace CSharpDom.TestTarget.AbstractClasses.OperatorOverloads
{
    public abstract class AbstractClassWithEqualAndNotEqualOperatorOverloads
    {
        public static bool operator ==(AbstractClassWithEqualAndNotEqualOperatorOverloads parameter1, AbstractClassWithEqualAndNotEqualOperatorOverloads parameter2)
        {
            return default(bool);
        }

        public static bool operator !=(AbstractClassWithEqualAndNotEqualOperatorOverloads parameter1, AbstractClassWithEqualAndNotEqualOperatorOverloads parameter2)
        {
            return default(bool);
        }
    }
}
