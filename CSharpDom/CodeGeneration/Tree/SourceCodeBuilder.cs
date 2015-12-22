using System;
using System.Collections.Generic;
using System.Linq;

namespace CSharpDom.CodeGeneration.Tree
{
    public class SourceCodeBuilder : CodeGenerationVisitor
    {
        // Type text
        public const string ClassText = "class ";
        public const string EnumText = "enum ";
        public const string DelegateText = "delegate ";
        public const string InterfaceText = "interface ";
        public const string StructText = "struct ";

        // Visibility text
        public const string PublicText = "public ";
        public const string InternalText = "internal ";
        public const string ProtectedText = "protected ";
        public const string ProtectedInternalText = "protected internal ";
        public const string PrivateText = "private ";
        
        // Inheritance modifier text
        public const string AbstractText = "abstract ";
        public const string NewText = "new ";
        public const string OverrideText = "override ";
        public const string SealedText = "sealed ";
        public const string StaticText = "static ";
        public const string VirtualText = "virtual ";

        // Miscellaneous modifier text
        public const string AsyncText = "async ";
        public const string ExplicitText = "explicit ";
        public const string ImplicitText = "implicit ";
        public const string OperatorText = "operator ";
        public const string PartialText = "partial ";

        // Field modifier text
        public const string ConstText = "const ";
        public const string ReadOnlyText = "readonly ";
        public const string VolatileText = "volatile ";

        // Property accessor text
        public const string GetText = "get";
        public const string SetText = "set";

        // Enum base type text
        public const string ByteText = " : byte";
        public const string SByteText = " : sbyte";
        public const string ShortText = " : short";
        public const string UShortText = " : ushort";
        public const string IntText = " : int";
        public const string UIntText = " : uint";
        public const string LongText = " : long";
        public const string ULongText = " : ulong";

        // Binary operator text
        public const string PlusText = "+";
        public const string MinusText = "-";
        public const string MultiplyText = "*";
        public const string DivideText = "/";
        public const string ModuloText = "%";
        public const string AndText = "&";
        public const string OrText = "|";
        public const string ExclusiveOrText = "^";
        public const string LeftShiftText = "<<";
        public const string RightShiftText = ">>";
        public const string EqualText = "==";
        public const string NotEqualText = "!=";
        public const string GreaterThanText = ">";
        public const string GreaterThanOrEqualText = ">=";
        public const string LessThanText = "<";
        public const string LessThanOrEqualText = "<=";

        // Unary operator text
        public const string IncrementText = "++";
        public const string DecrementText = "--";
        public const string LogicalNotText = "!";
        public const string BitwiseNotText = "~";
        public const string TrueText = "true";
        public const string FalseText = "false";

        // Parameter modifier text
        public const string RefText = "ref ";
        public const string OutText = "out ";
        public const string ParamsText = "params ";
        public const string ThisText = "this ";

        private static readonly IDictionary<Type, string> SpecialTypes = new Dictionary<Type, string>()
        {
            { typeof(bool), "bool" },
            { typeof(byte), "byte" },
            { typeof(sbyte), "sbyte" },
            { typeof(short), "short" },
            { typeof(ushort), "ushort" },
            { typeof(int), "int" },
            { typeof(uint), "uint" },
            { typeof(long), "long" },
            { typeof(ulong), "ulong" },
            { typeof(float), "float" },
            { typeof(double), "double" },
            { typeof(decimal), "decimal" },
            { typeof(string), "string" },
            { typeof(void), "void" }
        };

        private readonly SourceCodeTextBuilder textBuilder;
        private TypeReference currentType;
        private ClassPropertyAccessor currentClassPropertyGetAccessor;
        private string fieldComma;
        private StructPropertyAccessor currentStructPropertyGetAccessor;
        private Stack<bool> appendExtraLine;

        public SourceCodeBuilder()
        {
            textBuilder = new SourceCodeTextBuilder();
            appendExtraLine = new Stack<bool>(new bool[] { false });
        }

        public SourceCodeBuilder(SourceCodeTextBuilder textBuilder)
        {
            this.textBuilder = textBuilder;
        }

        public static string ToString(Type type)
        {
            string text;
            return SpecialTypes.TryGetValue(type, out text) ? text : type.Name;
        }

        public static string ToString(TypeVisibilityModifier visibility)
        {
            switch (visibility)
            {
                case TypeVisibilityModifier.None:
                    return string.Empty;
                case TypeVisibilityModifier.Public:
                    return PublicText;
                case TypeVisibilityModifier.Internal:
                    return InternalText;
                default:
                    throw new NotSupportedException();
            }
        }

        public static string ToString(ClassMemberVisibilityModifier visibility)
        {
            switch (visibility)
            {
                case ClassMemberVisibilityModifier.None:
                    return string.Empty;
                case ClassMemberVisibilityModifier.Public:
                    return PublicText;
                case ClassMemberVisibilityModifier.Internal:
                    return InternalText;
                case ClassMemberVisibilityModifier.ProtectedInternal:
                    return ProtectedInternalText;
                case ClassMemberVisibilityModifier.Protected:
                    return ProtectedText;
                case ClassMemberVisibilityModifier.Private:
                    return PrivateText;
                default:
                    throw new NotSupportedException();
            }
        }

        public static string ToString(ClassPropertyAccessorVisibilityModifier visibility)
        {
            switch (visibility)
            {
                case ClassPropertyAccessorVisibilityModifier.None:
                    return string.Empty;
                case ClassPropertyAccessorVisibilityModifier.Internal:
                    return InternalText;
                case ClassPropertyAccessorVisibilityModifier.ProtectedInternal:
                    return ProtectedInternalText;
                case ClassPropertyAccessorVisibilityModifier.Protected:
                    return ProtectedText;
                case ClassPropertyAccessorVisibilityModifier.Private:
                    return PrivateText;
                default:
                    throw new NotSupportedException();
            }
        }

        public static string ToString(StructPropertyAccessorVisibilityModifier visibility)
        {
            switch (visibility)
            {
                case StructPropertyAccessorVisibilityModifier.None:
                    return string.Empty;
                case StructPropertyAccessorVisibilityModifier.Internal:
                    return InternalText;
                case StructPropertyAccessorVisibilityModifier.Private:
                    return PrivateText;
                default:
                    throw new NotSupportedException();
            }
        }

        public static string ToString(TypeInheritanceModifier inheritanceModifier)
        {
            switch (inheritanceModifier)
            {
                case TypeInheritanceModifier.None:
                    return string.Empty;
                case TypeInheritanceModifier.Abstract:
                    return AbstractText;
                case TypeInheritanceModifier.Sealed:
                    return SealedText;
                case TypeInheritanceModifier.Static:
                    return StaticText;
                default:
                    throw new NotSupportedException();
            }
        }

        public static string ToString(ClassMemberInheritanceModifier inheritanceModifier)
        {
            switch (inheritanceModifier)
            {
                case ClassMemberInheritanceModifier.None:
                    return string.Empty;
                case ClassMemberInheritanceModifier.Abstract:
                    return AbstractText;
                case ClassMemberInheritanceModifier.New:
                    return NewText;
                case ClassMemberInheritanceModifier.NewStatic:
                    return NewText + StaticText;
                case ClassMemberInheritanceModifier.NewVirtual:
                    return NewText + VirtualText;
                case ClassMemberInheritanceModifier.Override:
                    return OverrideText;
                case ClassMemberInheritanceModifier.SealedOverride:
                    return SealedText + OverrideText;
                case ClassMemberInheritanceModifier.Static:
                    return StaticText;
                case ClassMemberInheritanceModifier.Virtual:
                    return VirtualText;
                default:
                    throw new NotSupportedException();
            }
        }

        public static string ToString(StructMethodInheritanceModifier inheritanceModifier)
        {
            switch (inheritanceModifier)
            {
                case StructMethodInheritanceModifier.None:
                    return string.Empty;
                case StructMethodInheritanceModifier.New:
                    return NewText;
                case StructMethodInheritanceModifier.NewStatic:
                    return NewText + StaticText;
                case StructMethodInheritanceModifier.Override:
                    return OverrideText;
                case StructMethodInheritanceModifier.Static:
                    return StaticText;
                default:
                    throw new NotSupportedException();
            }
        }

        public static string ToString(IndexerInheritanceModifier inheritanceModifier)
        {
            switch (inheritanceModifier)
            {
                case IndexerInheritanceModifier.None:
                    return string.Empty;
                case IndexerInheritanceModifier.Abstract:
                    return AbstractText;
                case IndexerInheritanceModifier.New:
                    return NewText;
                case IndexerInheritanceModifier.NewVirtual:
                    return NewText + VirtualText;
                case IndexerInheritanceModifier.Override:
                    return OverrideText;
                case IndexerInheritanceModifier.SealedOverride:
                    return SealedText + OverrideText;
                case IndexerInheritanceModifier.Virtual:
                    return VirtualText;
                default:
                    throw new NotSupportedException();
            }
        }

        public static string ToString(FieldModifier modifier)
        {
            switch (modifier)
            {
                case FieldModifier.None:
                    return string.Empty;
                case FieldModifier.Const:
                    return ConstText;
                case FieldModifier.ReadOnly:
                    return ReadOnlyText;
                case FieldModifier.Static:
                    return StaticText;
                case FieldModifier.StaticReadOnly:
                    return StaticText + ReadOnlyText;
                case FieldModifier.StaticVolatile:
                    return StaticText + VolatileText;
                case FieldModifier.Volatile:
                    return VolatileText;
                default:
                    throw new NotSupportedException();
            }
        }

        public static string ToString(EnumBaseType enumBaseType)
        {
            switch (enumBaseType)
            {
                case EnumBaseType.None:
                    return string.Empty;
                case EnumBaseType.Byte:
                    return ByteText;
                case EnumBaseType.SByte:
                    return SByteText;
                case EnumBaseType.Short:
                    return ShortText;
                case EnumBaseType.UShort:
                    return UShortText;
                case EnumBaseType.Int:
                    return IntText;
                case EnumBaseType.UInt:
                    return UIntText;
                case EnumBaseType.Long:
                    return LongText;
                case EnumBaseType.ULong:
                    return ULongText;
                default:
                    throw new NotSupportedException();
            }
        }

        public static string ToString(BinaryOperatorType operatorType)
        {
            switch (operatorType)
            {
                case BinaryOperatorType.Plus:
                    return PlusText;
                case BinaryOperatorType.Minus:
                    return MinusText;
                case BinaryOperatorType.Multiply:
                    return MultiplyText;
                case BinaryOperatorType.Divide:
                    return DivideText;
                case BinaryOperatorType.Modulo:
                    return ModuloText;
                case BinaryOperatorType.And:
                    return AndText;
                case BinaryOperatorType.Or:
                    return OrText;
                case BinaryOperatorType.ExclusiveOr:
                    return ExclusiveOrText;
                case BinaryOperatorType.LeftShift:
                    return LeftShiftText;
                case BinaryOperatorType.RightShift:
                    return RightShiftText;
                case BinaryOperatorType.Equal:
                    return EqualText;
                case BinaryOperatorType.NotEqual:
                    return NotEqualText;
                case BinaryOperatorType.GreaterThan:
                    return GreaterThanText;
                case BinaryOperatorType.GreaterThanOrEqual:
                    return GreaterThanOrEqualText;
                case BinaryOperatorType.LessThan:
                    return LessThanText;
                case BinaryOperatorType.LessThanOrEqual:
                    return LessThanOrEqualText;
                default:
                    throw new NotSupportedException();
            }
        }

        public static string ToString(ConversionOperatorType operatorType)
        {
            switch (operatorType)
            {
                case ConversionOperatorType.Implicit:
                    return ImplicitText;
                case ConversionOperatorType.Explicit:
                    return ExplicitText;
                default:
                    throw new NotSupportedException();
            }
        }

        public static string ToString(UnaryOperatorType operatorType)
        {
            switch (operatorType)
            {
                case UnaryOperatorType.Plus:
                    return PlusText;
                case UnaryOperatorType.Minus:
                    return MinusText;
                case UnaryOperatorType.Increment:
                    return IncrementText;
                case UnaryOperatorType.Decrement:
                    return DecrementText;
                case UnaryOperatorType.LogicalNot:
                    return LogicalNotText;
                case UnaryOperatorType.BitwiseNot:
                    return BitwiseNotText;
                case UnaryOperatorType.True:
                    return TrueText;
                case UnaryOperatorType.False:
                    return FalseText;
                default:
                    throw new NotSupportedException();
            }
        }

        public static string ToString(MethodParameterModifier modifier)
        {
            switch (modifier)
            {
                case MethodParameterModifier.None:
                    return string.Empty;
                case MethodParameterModifier.Out:
                    return OutText;
                case MethodParameterModifier.Ref:
                    return RefText;
                case MethodParameterModifier.Params:
                    return ParamsText;
                default:
                    throw new NotSupportedException();
            }
        }

        public static string ToString(ClassMethodParameterModifier modifier)
        {
            switch (modifier)
            {
                case ClassMethodParameterModifier.None:
                    return string.Empty;
                case ClassMethodParameterModifier.Out:
                    return OutText;
                case ClassMethodParameterModifier.Ref:
                    return RefText;
                case ClassMethodParameterModifier.Params:
                    return ParamsText;
                case ClassMethodParameterModifier.This:
                    return ThisText;
                default:
                    throw new NotSupportedException();
            }
        }

        public static string ToString(StructMemberVisibilityModifier modifier)
        {
            switch (modifier)
            {
                case StructMemberVisibilityModifier.None:
                    return string.Empty;
                case StructMemberVisibilityModifier.Public:
                    return PublicText;
                case StructMemberVisibilityModifier.Internal:
                    return InternalText;
                case StructMemberVisibilityModifier.Private:
                    return PrivateText;
                default:
                    throw new NotSupportedException();
            }
        }

        public static bool IsBooleanOperator(BinaryOperatorType operatorType)
        {
            return operatorType == BinaryOperatorType.Equal ||
                operatorType == BinaryOperatorType.NotEqual ||
                operatorType == BinaryOperatorType.GreaterThan ||
                operatorType == BinaryOperatorType.GreaterThanOrEqual ||
                operatorType == BinaryOperatorType.LessThan ||
                operatorType == BinaryOperatorType.LessThanOrEqual;
        }

        public static bool IsBooleanOperator(UnaryOperatorType operatorType)
        {
            return operatorType == UnaryOperatorType.LogicalNot ||
                operatorType == UnaryOperatorType.True ||
                operatorType == UnaryOperatorType.False;
        }

        public override string ToString()
        {
            return textBuilder.ToString();
        }

        public override void Visit(AssignStatement node)
        {
            AppendIndent();
            node.Left.Accept(this);
            Append(" = ");
            node.Right.Accept(this);
        }

        public override void Visit(BinaryOperator node)
        {
            AppendWithIndentAndExtraLine(PublicText + StaticText);
            AppendBinaryOperatorTypeReference(node.ReturnType, node.OperatorType);
            Append(" ");
            Append(OperatorText);
            Append(ToString(node.OperatorType));
            Append("(");
            node.Parameter1Type.AcceptIfNotNull(this);
            Append(" ");
            Append(node.Parameter1Name);
            Append(", ");
            node.Parameter2Type.AcceptIfNotNull(this);
            Append(" ");
            Append(node.Parameter2Name);
            Append(")");
            AppendBlock(node.Body);
        }

        public override void Visit(BlockStatement node)
        {
            AppendBlock(node.Statements);
        }

        public override void Visit(CatchStatement node)
        {
            AppendWithIndent("catch");
            if (node.Type != null)
            {
                Append(" (");
                node.Type.Accept(this);
                if (!string.IsNullOrWhiteSpace(node.Name))
                {
                    Append(" ");
                    Append(node.Name);
                }

                Append(")");
            }

            AppendBlock(node.Statements);
        }

        public override void Visit(Class node)
        {
            AppendWithIndent(ToString(node.Visibility));
            Append(ToString(node.InheritanceModifier));
            AppendPartial(node.IsPartial);
            Append(ClassText);
            Append(node.Name);
            AppendGenericParameters(node.GenericParameters);
            if (node.BaseClass != null)
            {
                Append(" : ");
                node.BaseClass.Accept(this);
            }

            AppendCommaSeparatedCollection(node.Interfaces, node.BaseClass == null ? " : " : ", ");
            AppendGenericParameterConstraints(node.GenericParameters);
            AppendBlock(node.Body);
        }

        public override void Visit(ClassEvent node)
        {
            AppendWithIndentAndExtraLine(ToString(node.Visibility));
            Append(ToString(node.InheritanceModifier));
            Append("event ");
            node.Type.Accept(this);
            Append(" ");
            Append(node.Name);
            if (node.Accessors == null)
            {
                Append(";");
            }
            else
            {
                AppendBlock(node.Accessors);
            }
        }

        public override void Visit(ClassFieldDeclaration node)
        {
            AppendWithIndent(ToString(node.Visibility));
            Append(ToString(node.Modifier));
            node.Type.Accept(this);
            AppendCommaSeparatedCollection(node.Fields, " ");
            Append(";");
        }

        public override void Visit(ClassIndexer node)
        {
            AppendWithIndentAndExtraLine(ToString(node.Visibility));
            Append(ToString(node.InheritanceModifier));
            node.Type.Accept(this);
            Append(" this[");
            AppendCommaSeparatedCollection(node.Parameters, string.Empty);
            Append("]");
            if (node.EmptyAccessors == null)
            {
                AppendWithIndent("{");
                using (IncrementIndent())
                {
                    node.GetAccessor.AcceptIfNotNull(this);
                    node.SetAccessor.AcceptIfNotNull(this);
                }

                AppendWithIndent("}");
            }
            else
            {
                Append(" { ");
                node.EmptyAccessors.Accept(this);
                Append(" }");
            }
        }

        public override void Visit(ClassMethod node)
        {
            AppendWithIndentAndExtraLine(ToString(node.Visibility));
            Append(ToString(node.InheritanceModifier));
            if (node.IsAsync)
            {
                Append(AsyncText);
            }

            if (node.IsPartial)
            {
                Append(PartialText);
            }

            node.ReturnType.Accept(this);
            Append(" ");
            Append(node.Name);
            AppendGenericParameters(node.GenericParameters);
            AppendMethodParameters(node.Parameters);
            AppendGenericParameterConstraints(node.GenericParameters);
            AppendBlock(node.Body);
        }

        public override void Visit(ClassMethodParameter node)
        {
            Append(ToString(node.Modifier));
            node.Type.Accept(this);
            Append(" ");
            Append(node.Name);
        }

        public override void Visit(ClassNestedClass node)
        {
            AppendWithIndentAndExtraLine(ToString(node.Visibility));
            Append(ToString(node.InheritanceModifier));
            AppendPartial(node.IsPartial);
            Append(ClassText);
            Append(node.Name);
            AppendGenericParameters(node.GenericParameters);
            if (node.BaseClass != null)
            {
                Append(" : ");
                node.BaseClass.Accept(this);
            }

            AppendCommaSeparatedCollection(node.Interfaces, node.BaseClass == null ? " : " : ", ");
            AppendGenericParameterConstraints(node.GenericParameters);
            AppendTypeBody(node.Body, new TypeReference(node));
        }

        public override void Visit(ClassNestedDelegate node)
        {
            AppendWithIndentAndExtraLine(ToString(node.Visibility));
            Append(DelegateText);
            node.ReturnType.Accept(this);
            Append(" ");
            Append(node.Name);
            AppendGenericParameters(node.GenericParameters);
            Append("(");
            AppendCommaSeparatedCollection(node.Parameters, string.Empty);
            Append(")");
            node.GenericParameters.AcceptIfNotNull(this);
            Append(";");
        }

        public override void Visit(ClassNestedEnum node)
        {
            AppendWithIndentAndExtraLine(ToString(node.Visibility));
            Append(EnumText);
            Append(node.Name);
            Append(ToString(node.BaseType));
            AppendWithIndent("{");
            using (IncrementIndent())
            {
                fieldComma = string.Empty;
                node.Fields.Accept(this);
            }

            AppendWithIndent("}");
        }

        public override void Visit(ClassNestedInterface node)
        {
            AppendWithIndentAndExtraLine(ToString(node.Visibility));
            AppendPartial(node.IsPartial);
            Append(InterfaceText);
            Append(node.Name);
            AppendGenericParameters(node.GenericParameters);
            AppendCommaSeparatedCollection(node.Interfaces, " : ");
            AppendGenericParameterConstraints(node.GenericParameters);
            AppendBlock(node.Body);
        }

        public override void Visit(ClassNestedStruct node)
        {
            AppendWithIndentAndExtraLine(ToString(node.Visibility));
            AppendPartial(node.IsPartial);
            Append(StructText);
            Append(node.Name);
            AppendGenericParameters(node.GenericParameters);
            AppendCommaSeparatedCollection(node.Interfaces, " : ");
            AppendGenericParameterConstraints(node.GenericParameters);
            AppendTypeBody(node.Body, new TypeReference(node));
        }

        public override void Visit(ClassProperty node)
        {
            AppendWithIndentAndExtraLine(ToString(node.Visibility));
            Append(ToString(node.InheritanceModifier));
            node.Type.Accept(this);
            Append(" ");
            Append(node.Name);
            if (node.EmptyAccessors == null)
            {
                currentClassPropertyGetAccessor = node.GetAccessor;
                AppendBlock(new PropertyAccessors<ClassPropertyAccessor>(node.GetAccessor, node.SetAccessor));
                currentClassPropertyGetAccessor = null;
            }
            else
            {
                Append(" { ");
                node.EmptyAccessors.Accept(this);
                Append(" }");
            }
        }

        public override void Visit(ClassPropertyAccessor node)
        {
            AppendWithIndent(ToString(node.Visibility));
            Append(currentClassPropertyGetAccessor == node ? GetText : SetText);
            switch (node.Body.Count)
            {
                case 0:
                    Append(" { }");
                    break;
                case 1:
                    Append(" {");
                    node.Body[0].Accept(this);
                    Append(" }");
                    break;
                default:
                    AppendBlock(node.Body);
                    break;
            }
        }

        public override void Visit(ClassReference node)
        {
            if (node.Type != null)
            {
                Append(node.Type.Name);
            }
            else if (node.Class != null)
            {
                Append(node.Class.Name);
            }
            else if (node.ClassNestedClass != null)
            {
                throw new NotSupportedException();
            }
            else if (node.StructNestedClass != null)
            {
                throw new NotSupportedException();
            }
            else if (node.TypeText != null)
            {
                Append(node.TypeText);
            }

            if (node.GenericParameters.Count != 0)
            {
                Append("<");
                AppendCommaSeparatedCollection(node.GenericParameters, string.Empty);
                Append(">");
            }
        }

        public override void Visit(CodeGenerationFile node)
        {
            node.Usings.AcceptIfNotNull(this);
            node.Namespaces.AcceptIfNotNull(this);
            AppendTypeContainer(node);
        }

        public override void Visit(ConversionOperator node)
        {
            AppendWithIndentAndExtraLine(PublicText + StaticText);
            Append(ToString(node.OperatorType));
            Append(OperatorText);
            AppendReference(node.ReturnType);
            Append("(");
            AppendReference(node.ParameterType);
            Append(" ");
            Append(node.ParameterName);
            Append(")");
            AppendBlock(node.Body);
        }

        public override void Visit(Delegate node)
        {
            AppendWithIndent(ToString(node.Visibility));
            Append(DelegateText);
            node.ReturnType.Accept(this);
            Append(" ");
            Append(node.Name);
            AppendGenericParameters(node.GenericParameters);
            Append("(");
            AppendCommaSeparatedCollection(node.Parameters, string.Empty);
            Append(")");
            node.GenericParameters.AcceptIfNotNull(this);
            Append(";");
        }

        public override void Visit(DelegateReference node)
        {
            if (node.Type != null)
            {
                Append(node.Type.Name);
            }
            else if (node.Delegate != null)
            {
                Append(node.Delegate.Name);
            }
            else if (node.ClassNestedDelegate != null)
            {
                throw new NotSupportedException();
            }
            else if (node.StructNestedDelegate != null)
            {
                throw new NotSupportedException();
            }
            else if (node.TypeText != null)
            {
                Append(node.TypeText);
            }

            if (node.GenericParameters != null && node.GenericParameters.Count != 0)
            {
                Append("<");
                AppendCommaSeparatedCollection(node.GenericParameters, string.Empty);
                Append(">");
            }
        }

        public override void Visit(DocumentationComment node)
        {
            AppendWithIndent("/// ");
            Append(node.Comment);
        }

        public override void Visit(DoStatement node)
        {
            AppendWithIndent("do");
            AppendWithIndent("{");
            node.Block.AcceptIfNotNull(this);
            AppendWithIndent("} while (");
            node.Condition.Accept(this);
            Append(");");
        }

        public override void Visit(EmptyClassPropertyAccessors node)
        {
            Append(ToString(node.GetAccessorVisibility));
            Append(GetText);
            Append("; ");
            Append(ToString(node.SetAccessorVisibility));
            Append(SetText);
            Append(";");
        }

        public override void Visit(EmptyStatement node)
        {
            AppendWithIndent(";");
        }

        public override void Visit(EmptyStructPropertyAccessors node)
        {
            Append(ToString(node.GetAccessorVisibility));
            Append(GetText);
            Append("; ");
            Append(ToString(node.SetAccessorVisibility));
            Append(SetText);
            Append(";");
        }

        public override void Visit(Enum node)
        {
            AppendWithIndent(ToString(node.Visibility));
            Append(EnumText);
            Append(node.Name);
            Append(ToString(node.BaseType));
            AppendWithIndent("{");
            using (IncrementIndent())
            {
                fieldComma = string.Empty;
                node.Fields.Accept(this);
            }

            AppendWithIndent("}");
        }

        public override void Visit(EnumField node)
        {
            Append(fieldComma);
            AppendWithIndent(node.Name);
            if (!string.IsNullOrWhiteSpace(node.RawInitialValue))
            {
                Append(" = ");
                Append(node.RawInitialValue);
            }

            fieldComma = ",";
        }

        public override void Visit(EventAccessors node)
        {
            AppendWithIndent("add");
            switch (node.AddBody.Count)
            {
                case 0:
                    Append(" { }");
                    break;
                case 1:
                    Append(" {");
                    node.AddBody[0].Accept(this);
                    Append("}");
                    break;
                default:
                    AppendBlock(node.AddBody);
                    break;
            }

            AppendWithIndent("remove");
            switch (node.RemoveBody.Count)
            {
                case 0:
                    Append(" { }");
                    break;
                case 1:
                    Append(" {");
                    node.RemoveBody[0].Accept(this);
                    Append("}");
                    break;
                default:
                    AppendBlock(node.RemoveBody);
                    break;
            }
        }

        public override void Visit(ExpressionStatement node)
        {
            if (node.Expression != null)
            {
                throw new NotSupportedException();
            }
            else if (node.RawExpression != null)
            {
                node.RawExpression.Accept(this);
            }
            else if (node.AssignExpression != null)
            {
                node.AssignExpression.Accept(this);
            }
        }

        public override void Visit(Field node)
        {
            Append(node.Name);
            if (!string.IsNullOrWhiteSpace(node.RawInitialValue))
            {
                Append(" = ");
                Append(node.RawInitialValue);
            }
            else if (node.InitialValue != null)
            {
                throw new NotSupportedException();
            }
        }

        public override void Visit(FinallyStatement node)
        {
            AppendWithIndent("finally");
            AppendBlock(node.Statements);
        }

        public override void Visit(ForeachStatement node)
        {
            AppendWithIndent("foreach (");
            node.Type.Accept(this);
            Append(node.VariableName);
            Append(" in ");
            node.Iterator.Accept(this);
            Append(")");
            using (IncrementIndent())
            {
                node.Statement.Accept(this);
            }
        }

        public override void Visit(ForStatement node)
        {
            AppendWithIndent("for (");
            node.InitialValueExpression.AcceptIfNotNull(this);
            node.InitialValueStatement.AcceptIfNotNull(this);
            Append(" ");
            node.Condition.AcceptIfNotNull(this);
            Append(" ");
            node.Increment.AcceptIfNotNull(this);
            Append(")");
            using (IncrementIndent())
            {
                node.Statement.Accept(this);
            }
        }

        public override void Visit(GenericParameter node)
        {
            using (IncrementIndent())
            {
                bool hasWhere = false;
                if (node.BaseClassConstraint != null)
                {
                    AppendWithIndent("where " + node.Name + " : ");
                    hasWhere = true;
                    node.BaseClassConstraint.Accept(this);
                }
                else if (node.TypeConstraint != GenericParameterTypeConstraintModifier.None)
                {
                    AppendWithIndent("where " + node.Name + " : ");
                    hasWhere = true;
                    Append(node.TypeConstraint == GenericParameterTypeConstraintModifier.Class ? "class" : "struct");
                }

                if (node.GenericParameterConstraints != null && node.GenericParameterConstraints.Count != 0)
                {
                    AppendWhereOrComma(hasWhere, node);
                    hasWhere = true;
                    AppendCommaSeparatedCollection(node.GenericParameterConstraints, string.Empty);
                }

                if (node.InterfaceConstraints != null && node.InterfaceConstraints.Count != 0)
                {
                    AppendWhereOrComma(hasWhere, node);
                    hasWhere = true;
                    AppendCommaSeparatedCollection(node.InterfaceConstraints, string.Empty);
                }

                if (node.HasEmptyConstructorConstraint)
                {
                    AppendWhereOrComma(hasWhere, node);
                    Append("new()");
                }
            }
        }

        public override void Visit(GenericParameterReference node)
        {
            if (node.Type != null)
            {
                Append(node.Type.Name);
            }
            else if (node.GenericParameter != null)
            {
                Append(node.GenericParameter.Name);
            }
            else if (node.TypeText != null)
            {
                Append(node.TypeText);
            }
        }

        public override void Visit(GotoStatement node)
        {
            AppendWithIndent("goto ");
            node.Label.Accept(this);
        }

        public override void Visit(IfStatement node)
        {
            AppendWithIndent("if (");
            node.Condition.Accept(this);
            Append("(");
            using (IncrementIndent())
            {
                node.ThenStatement.Accept(this);
            }

            if (node.ElseStatement != null)
            {
                AppendWithIndent("else");
                using (IncrementIndent())
                {
                    node.ElseStatement.Accept(this);
                }
            }
        }

        public override void Visit(Interface node)
        {
            AppendWithIndent(ToString(node.Visibility));
            AppendPartial(node.IsPartial);
            Append(InterfaceText);
            Append(node.Name);
            AppendGenericParameters(node.GenericParameters);
            AppendCommaSeparatedCollection(node.Interfaces, " : ");
            AppendGenericParameterConstraints(node.GenericParameters);
            AppendBlock(node.Body);
        }

        public override void Visit(InterfaceReference node)
        {
            if (node.Type != null)
            {
                Append(node.Type.Name);
            }
            else if (node.Interface != null)
            {
                Append(node.Interface.Name);
            }
            else if (node.ClassNestedInterface != null)
            {
                throw new NotSupportedException();
            }
            else if (node.StructNestedInterface != null)
            {
                throw new NotSupportedException();
            }
            else if (node.TypeText != null)
            {
                Append(node.TypeText);
            }

            if (node.GenericParameters != null && node.GenericParameters.Count != 0)
            {
                Append("<");
                AppendCommaSeparatedCollection(node.GenericParameters, string.Empty);
                Append(">");
            }
        }

        public override void Visit(InterfaceEvent node)
        {
            AppendIndentAndExtraLine();
            if (node.IsNew)
            {
                Append(NewText);
            }

            node.Type.Accept(this);
            Append(node.Name);
            Append(";");
        }

        public override void Visit(InterfaceMethod node)
        {
            AppendIndentAndExtraLine();
            if (node.IsNew)
            {
                Append("new ");
            }

            node.ReturnType.Accept(this);
            Append(node.Name);
            AppendGenericParameters(node.GenericParameters);
            AppendMethodParameters(node.Parameters);
            AppendGenericParameterConstraints(node.GenericParameters);
            Append(";");
        }

        public override void Visit(InterfaceProperty node)
        {
            AppendIndentAndExtraLine();
            if (node.IsNew)
            {
                Append("new ");
            }

            node.Type.Accept(this);
            Append(" { ");
            switch (node.Accessors)
            {
                case InterfacePropertyAccessors.Get:
                    Append("get;");
                    break;
                case InterfacePropertyAccessors.Set:
                    Append("set;");
                    break;
                case InterfacePropertyAccessors.GetAndSet:
                    Append("get; set;");
                    break;
            }

            Append(" } ");
        }

        public override void Visit(LabelReference node)
        {
            Append(node.Label);
        }

        public override void Visit(LabelStatement node)
        {
            AppendIndent();
            node.Label.Accept(this);
            Append(":");
        }

        public override void Visit(LockStatement node)
        {
            AppendWithIndent("lock (");
            node.Expression.Accept(this);
            Append(")");
            node.Statement.Accept(this);
        }

        public override void Visit(MethodParameter node)
        {
            Append(ToString(node.Modifier));
            node.Type.Accept(this);
            Append(" ");
            Append(node.Name);
        }

        public override void Visit(MultiLineComment node)
        {
            AppendWithIndent("/*");
            Append(node.Comment);
            Append("*/");
        }

        public override void Visit(Namespace node)
        {
            AppendIndent();
            AppendWithIndent("namespace ");
            Append(node.Name);
            AppendWithIndent("{");
            using (IncrementIndent())
            {
                node.Usings.AcceptIfNotNull(this);
                node.Namespaces.AcceptIfNotNull(this);
                AppendTypeContainer(node);
            }

            AppendWithIndent("}");
        }

        public override void Visit(RawStatement node)
        {
            AppendWithIndent(node.Statement);
        }

        public override void Visit(ReturnStatement node)
        {
            if (string.IsNullOrWhiteSpace(node.RawExpression))
            {
                throw new NotSupportedException();
            }

            AppendWithIndent("return ");
            Append(node.RawExpression);
            Append(";");
        }

        public override void Visit(SingleLineComment node)
        {
            AppendWithIndent("// ");
            Append(node.Comment);
        }

        public override void Visit(Struct node)
        {
            AppendWithIndent(ToString(node.Visibility));
            AppendPartial(node.IsPartial);
            Append(StructText);
            Append(node.Name);
            AppendGenericParameters(node.GenericParameters);
            AppendCommaSeparatedCollection(node.Interfaces, " : ");
            AppendGenericParameterConstraints(node.GenericParameters);
            AppendBlock(node.Body);
        }

        public override void Visit(StructEvent node)
        {
            AppendWithIndentAndExtraLine(ToString(node.Visibility));
            if (node.IsStatic)
            {
                Append(StaticText);
            }

            Append("event ");
            node.Type.Accept(this);
            Append(" ");
            Append(node.Name);
            if (node.Accessors == null)
            {
                Append(";");
            }
            else
            {
                AppendBlock(node.Accessors);
            }
        }

        public override void Visit(StructFieldDeclaration node)
        {
            AppendWithIndent(ToString(node.Visibility));
            Append(ToString(node.Modifier));
            node.Type.Accept(this);
            Append(" ");
            AppendCommaSeparatedCollection(node.Fields, string.Empty);
            Append(";");
        }

        public override void Visit(StructIndexer node)
        {
            AppendWithIndentAndExtraLine(ToString(node.Visibility));
            node.Type.Accept(this);
            Append(" this[");
            AppendCommaSeparatedCollection(node.Parameters, string.Empty);
            Append("]");
            AppendWithIndent("{");
            using (IncrementIndent())
            {
                node.GetAccessor.AcceptIfNotNull(this);
                node.SetAccessor.AcceptIfNotNull(this);
            }

            AppendWithIndent("}");
        }

        public override void Visit(StructMethod node)
        {
            AppendWithIndentAndExtraLine(ToString(node.Visibility));
            Append(ToString(node.InheritanceModifier));
            if (node.IsAsync)
            {
                Append(AsyncText);
            }

            if (node.IsPartial)
            {
                Append(PartialText);
            }

            node.ReturnType.Accept(this);
            Append(" ");
            Append(node.Name);
            AppendGenericParameters(node.GenericParameters);
            AppendMethodParameters(node.Parameters);
            AppendGenericParameterConstraints(node.GenericParameters);
            AppendBlock(node.Body);
        }

        public override void Visit(StructNestedClass node)
        {
            AppendWithIndentAndExtraLine(ToString(node.Visibility));
            Append(ToString(node.InheritanceModifier));
            AppendPartial(node.IsPartial);
            Append(ClassText);
            Append(node.Name);
            AppendGenericParameters(node.GenericParameters);
            if (node.BaseClass != null)
            {
                Append(" : ");
                node.BaseClass.Accept(this);
            }

            AppendCommaSeparatedCollection(node.Interfaces, node.BaseClass == null ? " : " : ", ");
            AppendGenericParameterConstraints(node.GenericParameters);
            AppendTypeBody(node.Body, new TypeReference(node));
        }

        public override void Visit(StructNestedDelegate node)
        {
            AppendWithIndentAndExtraLine(ToString(node.Visibility));
            Append(DelegateText);
            node.ReturnType.Accept(this);
            Append(" ");
            Append(node.Name);
            AppendGenericParameters(node.GenericParameters);
            Append("(");
            AppendCommaSeparatedCollection(node.Parameters, string.Empty);
            Append(")");
            node.GenericParameters.AcceptIfNotNull(this);
            Append(";");
        }

        public override void Visit(StructNestedEnum node)
        {
            AppendWithIndentAndExtraLine(ToString(node.Visibility));
            Append(EnumText);
            Append(node.Name);
            Append(ToString(node.BaseType));
            AppendWithIndent("{");
            using (IncrementIndent())
            {
                fieldComma = string.Empty;
                node.Fields.Accept(this);
            }

            AppendWithIndent("}");
        }

        public override void Visit(StructNestedInterface node)
        {
            AppendWithIndentAndExtraLine(ToString(node.Visibility));
            AppendPartial(node.IsPartial);
            Append(InterfaceText);
            Append(node.Name);
            AppendGenericParameters(node.GenericParameters);
            AppendCommaSeparatedCollection(node.Interfaces, " : ");
            AppendGenericParameterConstraints(node.GenericParameters);
            AppendBlock(node.Body);
        }

        public override void Visit(StructNestedStruct node)
        {
            AppendWithIndentAndExtraLine(ToString(node.Visibility));
            AppendPartial(node.IsPartial);
            Append(StructText);
            Append(node.Name);
            AppendGenericParameters(node.GenericParameters);
            AppendCommaSeparatedCollection(node.Interfaces, " : ");
            AppendGenericParameterConstraints(node.GenericParameters);
            AppendTypeBody(node.Body, new TypeReference(node));
        }

        public override void Visit(StructProperty node)
        {
            AppendWithIndentAndExtraLine(ToString(node.Visibility));
            if (node.IsStatic)
            {
                Append(StaticText);
            }

            node.Type.Accept(this);
            Append(" ");
            Append(node.Name);
            if (node.EmptyAccessors == null)
            {
                currentStructPropertyGetAccessor = node.GetAccessor;
                AppendBlock(new PropertyAccessors<StructPropertyAccessor>(node.GetAccessor, node.SetAccessor));
                currentStructPropertyGetAccessor = null;
            }
            else
            {
                Append(" { ");
                node.EmptyAccessors.Accept(this);
                Append(" }");
            }
        }

        public override void Visit(StructPropertyAccessor node)
        {
            AppendWithIndentAndExtraLine(ToString(node.Visibility));
            Append(currentStructPropertyGetAccessor == node ? GetText : SetText);
            switch (node.Body.Count)
            {
                case 0:
                    Append(" { }");
                    break;
                case 1:
                    Append(" {");
                    node.Body[0].Accept(this);
                    Append(" }");
                    break;
                default:
                    AppendBlock(node.Body);
                    break;
            }
        }

        public override void Visit(SwitchCaseStatement node)
        {
            AppendWithIndent("case ");
            node.Match.Accept(this);
            Append(":");
            using (IncrementIndent())
            {
                node.Statements.AcceptIfNotNull(this);
            }
        }

        public override void Visit(SwitchStatement node)
        {
            AppendWithIndent("switch (");
            node.Expression.Accept(this);
            Append(")");
            AppendWithIndent("{");
            using (IncrementIndent())
            {
                node.Cases.AcceptIfNotNull(this);
                if (node.DefaultCase != null && node.DefaultCase.Count != 0)
                {
                    AppendWithIndent("default:");
                    using (IncrementIndent())
                    {
                        node.DefaultCase.Accept(this);
                    }
                }
            }

            AppendWithIndent("}");
        }

        public override void Visit(TypeReference node)
        {
            if (node.Type != null)
            {
                Append(ToString(node.Type));
            }
            else if (node.Class != null)
            {
                Append(node.Class.Name);
            }
            else if (node.ClassNestedClass != null)
            {
                throw new NotSupportedException();
            }
            else if (node.StructNestedClass != null)
            {
                throw new NotSupportedException();
            }
            else if (node.TypeText != null)
            {
                Append(node.TypeText);
            }

            if (node.GenericParameters != null && node.GenericParameters.Count != 0)
            {
                Append("<");
                AppendCommaSeparatedCollection(node.GenericParameters, string.Empty);
                Append(">");
            }
        }

        public override void Visit(TryStatement node)
        {
            AppendWithIndent("try");
            AppendBlock(node.TryStatements);
            node.CatchStatements.AcceptIfNotNull(this);
            node.FinallyStatement.AcceptIfNotNull(this);
        }

        public override void Visit(UnaryOperator node)
        {
            AppendWithIndentAndExtraLine(PublicText + StaticText);
            AppendUnaryOperatorTypeReference(node.ReturnType, node.OperatorType);
            Append(" ");
            Append(OperatorText);
            Append(ToString(node.OperatorType));
            Append("(");
            node.ParameterType.AcceptIfNotNull(this);
            Append(" ");
            Append(node.ParameterName);
            Append(")");
            AppendBlock(node.Body);
        }

        public override void Visit(UsingDeclaration node)
        {
            AppendWithIndent("using ");
            Append(node.Namespace);
            Append(";");
        }

        public override void Visit(UsingStatement node)
        {
            AppendWithIndent("using (");
            node.Expression.Accept(this);
            Append(")");
            node.Statement.Accept(this);
        }

        public override void Visit(VariableDeclaration node)
        {
            Append(node.Name);
            if (node.InitialValue != null)
            {
                Append(" = ");
                node.InitialValue.Accept(this);
            }
        }

        public override void Visit(VariableDeclarationStatement node)
        {
            AppendIndent();
            node.Type.Accept(this);
            AppendCommaSeparatedCollection(node.VariableDeclarations, string.Empty);
        }

        public override void Visit(WhileStatement node)
        {
            AppendWithIndent("while (");
            node.Condition.Accept(this);
            Append(")");
            node.Statement.Accept(this);
        }
        
        protected void Append(string text)
        {
            textBuilder.Append(text);
        }

        protected void AppendIndent()
        {
            textBuilder.AppendIndent();
        }

        protected void AppendIndentAndExtraLine()
        {
            textBuilder.AppendIndent();
        }

        protected void AppendExtraLine()
        {
            if (appendExtraLine.Peek())
            {
                textBuilder.AppendLine();
            }

            if (!appendExtraLine.Peek())
            {
                appendExtraLine.Pop();
                appendExtraLine.Push(true);
            }
        }

        protected void AppendWithIndent(string text)
        {
            textBuilder.AppendWithIndent(text);
        }

        protected void AppendWithIndentAndExtraLine(string text)
        {
            AppendExtraLine();
            textBuilder.AppendWithIndent(text);
        }

        protected IDisposable IncrementIndent()
        {
            return textBuilder.IncrementIndent();
        }

        private void AppendTypeContainer(TypeContainer node)
        {
            node.Delegates.AcceptIfNotNull(this);
            node.Enums.AcceptIfNotNull(this);
            node.Interfaces.AcceptIfNotNull(this);
            node.Structs.AcceptIfNotNull(this);
            node.Classes.AcceptIfNotNull(this);
        }

        private void AppendWhereOrComma(bool hasWhere, GenericParameter node)
        {
            if (hasWhere)
            {
                Append(", ");
            }
            else
            {
                AppendWithIndent("where " + node.Name + " : ");
            }
        }

        private void AppendCommaSeparatedCollection<T>(CodeGenerationCollection<T> collection, string initialCommaText)
            where T : CodeGenerationNode
        {
            if (collection == null)
            {
                return;
            }

            string comma = initialCommaText;
            foreach (T item in collection)
            {
                Append(comma);
                item.Accept(this);
                comma = ", ";
            }
        }

        private void AppendBlock(ICodeGenerationNode node)
        {
            AppendWithIndent("{");
            using (IncrementIndent())
            {
                node.Accept(this);
            }

            AppendWithIndent("}");
        }
        
        private void AppendGenericParameters(CodeGenerationCollection<GenericParameter> genericParameters)
        {
            if (genericParameters != null && genericParameters.Count != 0)
            {
                Append("<" + string.Join(", ", genericParameters.Select(parameter => parameter.Name)) + ">");
            }
        }

        private void AppendGenericParameterConstraints(CodeGenerationCollection<GenericParameter> genericParameters)
        {
            genericParameters.AcceptIfNotNull(this);
        }

        private void AppendMethodParameters(CodeGenerationCollection<MethodParameter> parameters)
        {
            Append("(");
            AppendCommaSeparatedCollection(parameters, string.Empty);
            Append(")");
        }

        private void AppendMethodParameters(CodeGenerationCollection<ClassMethodParameter> parameters)
        {
            Append("(");
            AppendCommaSeparatedCollection(parameters, string.Empty);
            Append(")");
        }

        private void AppendPartial(bool isPartial)
        {
            if (isPartial)
            {
                Append(PartialText);
            }
        }

        private void AppendTypeBody(ICodeGenerationNode node, TypeReference reference)
        {
            TypeReference previousType = currentType;
            currentType = reference;
            AppendBlock(node);
            currentType = previousType;
        }

        private void AppendBinaryOperatorTypeReference(TypeReference reference, BinaryOperatorType operatorType)
        {
            if (reference == null && IsBooleanOperator(operatorType))
            {
                Append("bool");
            }
            else
            {
                AppendReference(reference);
            }
        }

        private void AppendUnaryOperatorTypeReference(TypeReference reference, UnaryOperatorType operatorType)
        {
            if (reference == null && IsBooleanOperator(operatorType))
            {
                Append("bool");
            }
            else
            {
                AppendReference(reference);
            }
        }

        private void AppendReference(TypeReference reference)
        {
            if (reference == null)
            {
                currentType.Accept(this);
            }
            else
            {
                reference.Accept(this);
            }
        }
    }
}
