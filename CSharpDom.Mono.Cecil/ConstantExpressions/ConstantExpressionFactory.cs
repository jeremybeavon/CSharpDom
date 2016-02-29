using Mono.Cecil;
using System;

namespace CSharpDom.Mono.Cecil.ConstantExpressions
{
    internal static class ConstantExpressionFactory
    {
        public static IConstantExpressionWithMonoCecil CreateExpression(AssemblyWithMonoCecil assembly, object value)
        {
            if (value == null)
            {
                return new NullExpressionWithMonoCecil();
            }

            TypeDefinition type = value as TypeDefinition;
            if (type != null)
            {
                return new TypeofExpressionWithMonoCecil(TypeReferenceWithMonoCecilFactory.CreateReference(assembly, type));
            }

            /*switch (TypeDefinition.GetTypeCode(value.GetType()))
            {
                case TypeCode.Double:
                    return new DoubleConstantExpressionWithMonoCecil((double)value);
                case TypeCode.Int32:
                    return new IntegerConstantExpressionWithMonoCecil((int)value);
                case TypeCode.String:
                    return new StringConstantExpressionWithMonoCecil((string)value);
                default:
                    throw new NotImplementedException();
            }*/
            throw new NotImplementedException();
        }
    }
}
