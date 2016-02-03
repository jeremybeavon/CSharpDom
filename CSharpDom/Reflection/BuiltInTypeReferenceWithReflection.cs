using System;
using CSharpDom.BaseClasses;

namespace CSharpDom.Reflection
{
    public sealed class BuiltInTypeReferenceWithReflection : AbstractBuiltInTypeReference, ITypeReferenceWithReflection
    {
        private readonly BuiltInType type;

        internal BuiltInTypeReferenceWithReflection(BuiltInType type)
        {
            this.type = type;
        }

        public override BuiltInType Type
        {
            get { return type; }
        }

        Type IHasType.Type
        {
            get
            {
                switch (type)
                {
                    case BuiltInType.Bool:
                        return typeof(bool);
                    case BuiltInType.Byte:
                        return typeof(byte);
                    case BuiltInType.Char:
                        return typeof(char);
                    case BuiltInType.Decimal:
                        return typeof(decimal);
                    case BuiltInType.Double:
                        return typeof(double);
                    case BuiltInType.Float:
                        return typeof(float);
                    case BuiltInType.Int:
                        return typeof(int);
                    case BuiltInType.Long:
                        return typeof(long);
                    case BuiltInType.SByte:
                        return typeof(sbyte);
                    case BuiltInType.Short:
                        return typeof(short);
                    case BuiltInType.String:
                        return typeof(string);
                    case BuiltInType.UInt:
                        return typeof(uint);
                    case BuiltInType.ULong:
                        return typeof(ulong);
                    case BuiltInType.UShort:
                        return typeof(ushort);
                    case BuiltInType.Void:
                        return typeof(void);
                    default:
                        throw new NotSupportedException();
                }
            }
        }
    }
}
