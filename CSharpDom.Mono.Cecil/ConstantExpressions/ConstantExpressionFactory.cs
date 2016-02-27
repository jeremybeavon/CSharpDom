using System;

namespace CSharpDom.Mono.Cecil.ConstantExpressions
{
    internal static class ConstantExpressionFactory
    {
        public static IConstantExpressionWithMonoCecil CreateExpression(object value)
        {
            if (value == null)
            {
                return new NullExpressionWithMonoCecil();
            }

            Type type = value as Type;
            if (type != null)
            {
                return new TypeofExpressionWithMonoCecil(TypeReferenceWithMonoCecilFactory.CreateReference(type));
            }

            switch (Type.GetTypeCode(value.GetType()))
            {
                case TypeCode.Double:
                    return new DoubleConstantExpressionWithMonoCecil((double)value);
                case TypeCode.Int32:
                    return new IntegerConstantExpressionWithMonoCecil((int)value);
                case TypeCode.String:
                    return new StringConstantExpressionWithMonoCecil((string)value);
                default:
                    throw new NotImplementedException();
            }
        }
    }
}
