using System;

namespace CSharpDom.Reflection.ConstantExpressions
{
    internal static class ConstantExpressionFactory
    {
        public static IConstantExpressionWithReflection CreateExpression(object value)
        {
            if (value == null)
            {
                return new NullExpressionWithReflection();
            }

            Type type = value as Type;
            if (type != null)
            {
                return new TypeofExpressionWithReflection(TypeReferenceWithReflectionFactory.CreateReference(type));
            }

            switch (Type.GetTypeCode(value.GetType()))
            {
                case TypeCode.Double:
                    return new DoubleConstantExpressionWithReflection((double)value);
                case TypeCode.Int32:
                    return new IntegerConstantExpressionWithReflection((int)value);
                case TypeCode.String:
                    return new StringConstantExpressionWithReflection((string)value);
                default:
                    throw new NotImplementedException();
            }
        }
    }
}
