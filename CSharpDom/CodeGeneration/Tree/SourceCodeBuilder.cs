using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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

        // Operator text
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

        private readonly SourceCodeTextBuilder textBuilder;
        private TypeReference currentType;
        private ClassPropertyAccessor currentClassPropertyGetAccessor;

        public SourceCodeBuilder()
        {
            textBuilder = new SourceCodeTextBuilder();
        }

        public SourceCodeBuilder(SourceCodeTextBuilder textBuilder)
        {
            this.textBuilder = textBuilder;
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

        public static string ToString(MemberInheritanceModifier inheritanceModifier)
        {
            switch (inheritanceModifier)
            {
                case MemberInheritanceModifier.None:
                    return string.Empty;
                case MemberInheritanceModifier.Abstract:
                    return AbstractText;
                case MemberInheritanceModifier.New:
                    return NewText;
                case MemberInheritanceModifier.NewStatic:
                    return NewText + StaticText;
                case MemberInheritanceModifier.NewVirtual:
                    return NewText + VirtualText;
                case MemberInheritanceModifier.Override:
                    return OverrideText;
                case MemberInheritanceModifier.SealedOverride:
                    return SealedText + OverrideText;
                case MemberInheritanceModifier.Static:
                    return StaticText;
                case MemberInheritanceModifier.Virtual:
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

        public static bool IsBooleanOperator(BinaryOperatorType operatorType)
        {
            return operatorType == BinaryOperatorType.Equal ||
                operatorType == BinaryOperatorType.NotEqual ||
                operatorType == BinaryOperatorType.GreaterThan ||
                operatorType == BinaryOperatorType.GreaterThanOrEqual ||
                operatorType == BinaryOperatorType.LessThan ||
                operatorType == BinaryOperatorType.LessThanOrEqual;
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
            AppendWithIndent(PublicText + StaticText);
            AppendBinaryOperatorTypeReference(node.ReturnType, node.OperatorType);
            Append(OperatorText);
            Append(ToString(node.OperatorType));
            Append("(");
            AppendBinaryOperatorTypeReference(node.Parameter1Type, node.OperatorType);
            Append(node.Parameter1Name);
            Append(", ");
            AppendBinaryOperatorTypeReference(node.Parameter2Type, node.OperatorType);
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
            AppendWithIndent(ToString(node.Visibility));
            Append(ToString(node.InheritanceModifier));
            node.Type.Accept(this);
            Append(node.Name);
            if (node.Accessors != null)
            {
                node.Accessors.Accept(this);
            }
        }

        public override void Visit(ClassFieldDeclaration node)
        {
            AppendWithIndent(ToString(node.Visibility));
            Append(ToString(node.Modifier));
            node.Type.Accept(this);
            AppendCommaSeparatedCollection(node.Fields, string.Empty);
        }

        public override void Visit(ClassIndexer node)
        {
            AppendWithIndent(ToString(node.Visibility));
            Append(ToString(node.InheritanceModifier));
            node.Type.Accept(this);
            Append("this[");
            AppendCommaSeparatedCollection(node.Parameters, string.Empty);
            Append("]");
            AppendWithIndent("{");
            using (IncrementIndent())
            {
                if (node.GetAccessor != null)
                {
                    node.GetAccessor.Accept(this);
                }

                if (node.SetAccessor != null)
                {
                    node.SetAccessor.Accept(this);
                }
            }

            AppendWithIndent("}");
        }

        public override void Visit(ClassMethod node)
        {
            AppendWithIndent(ToString(node.Visibility));
            Append(ToString(node.InheritanceModifier));
            if (node.IsAsync)
            {
                Append("async ");
            }

            node.ReturnType.Accept(this);
            Append(node.Name);
            AppendGenericParameters(node.GenericParameters);
            Append("(");
            AppendCommaSeparatedCollection(node.Parameters, string.Empty);
            Append(")");
            AppendGenericParameterConstraints(node.GenericParameters);
            AppendBlock(node.Body);
        }

        public override void Visit(ClassNestedClass node)
        {
            AppendWithIndent(ToString(node.Visibility));
            Append(ToString(node.InheritanceModifier));
            AppendPartial(node.IsPartial);
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
            AppendWithIndent(ToString(node.Visibility));
            Append(DelegateText);
            node.ReturnType.Accept(this);
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
            AppendWithIndent(ToString(node.Visibility));
            Append(EnumText);
            Append(node.Name);
            Append(ToString(node.BaseType));
            AppendWithIndent("{");
            using (IncrementIndent())
            {
                node.Fields.Accept(this);
            }

            AppendWithIndent("}");
        }

        public override void Visit(ClassNestedInterface node)
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

        public override void Visit(ClassNestedStruct node)
        {
            AppendWithIndent(ToString(node.Visibility));
            AppendPartial(node.IsPartial);
            Append(node.Name);
            AppendGenericParameters(node.GenericParameters);
            AppendCommaSeparatedCollection(node.Interfaces, " : ");
            AppendGenericParameterConstraints(node.GenericParameters);
            AppendTypeBody(node.Body, new TypeReference(node));
        }

        public override void Visit(ClassProperty node)
        {
            AppendWithIndent(ToString(node.Visibility));
            Append(ToString(node.InheritanceModifier));
            node.Type.Accept(this);
            Append(node.Name);
            if (node.EmptyAccessors == null)
            {
                currentClassPropertyGetAccessor = node.GetAccessor;
                AppendBlock(new PropertyAccessors<ClassPropertyAccessor>(node.GetAccessor, node.SetAccessor));
                currentClassPropertyGetAccessor = null;
            }
            else
            {
                node.EmptyAccessors.Accept(this);
            }
        }

        public override void Visit(ClassPropertyAccessor node)
        {
            AppendWithIndent(ToString(node.Visibility));
            Append(currentClassPropertyGetAccessor == node ? GetText : SetText);
            if (node.Body.Count == 1)
            {
                Append(" {");
                node.Body[0].Accept(this);
                Append(" }");
            }
            else
            {
                AppendBlock(node.Body);
            }
        }

        public override void Visit(ConversionOperator node)
        {
            AppendWithIndent(PublicText + StaticText);
            Append(ToString(node.OperatorType));
            Append(OperatorText);
            AppendReference(node.ReturnType);
            Append("(");
            AppendReference(node.ParameterType);
            Append(node.ParameterName);
            Append(")");
            AppendBlock(node.Body);
        }

        public override void Visit(Delegate node)
        {
            AppendWithIndent(ToString(node.Visibility));
            Append(DelegateText);
            node.ReturnType.Accept(this);
            Append(node.Name);
            AppendGenericParameters(node.GenericParameters);
            Append("(");
            AppendCommaSeparatedCollection(node.Parameters, string.Empty);
            Append(")");
            node.GenericParameters.AcceptIfNotNull(this);
            Append(";");
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
                node.Fields.Accept(this);
            }

            AppendWithIndent("}");
        }

        public override void Visit(GenericParameter node)
        {
            using (IncrementIndent())
            {
                bool hasWhere = false;
                if (node.BaseClassConstraint != null)
                {
                    AppendWithIndent("where ");
                    hasWhere = true;
                    node.BaseClassConstraint.Accept(this);
                }
                else if (node.TypeConstraint != GenericParameteTypeConstraintModifier.None)
                {
                    AppendWithIndent("where ");
                    hasWhere = true;
                    Append(node.TypeConstraint == GenericParameteTypeConstraintModifier.Class ? "class" : "struct");
                }

                if (node.GenericParameterConstraints != null && node.GenericParameterConstraints.Count != 0)
                {
                    AppendWhereOrComma(hasWhere);
                    hasWhere = true;
                    AppendCommaSeparatedCollection(node.GenericParameterConstraints, string.Empty);
                }

                if (node.InterfaceConstraints != null && node.InterfaceConstraints.Count != 0)
                {
                    AppendWhereOrComma(hasWhere);
                    hasWhere = true;
                    AppendCommaSeparatedCollection(node.InterfaceConstraints, string.Empty);
                }

                if (node.HasEmptyConstructorConstraint)
                {
                    AppendWhereOrComma(hasWhere);
                    Append("new()");
                }
            }
        }

        protected void Append(string text)
        {
            textBuilder.Append(text);
        }

        protected void AppendIndent()
        {
            textBuilder.AppendIndent();
        }

        protected void AppendWithIndent(string text)
        {
            textBuilder.AppendWithIndent(text);
        }

        protected IDisposable IncrementIndent()
        {
            return textBuilder.IncrementIndent();
        }

        private void AppendWhereOrComma(bool hasWhere)
        {
            if (hasWhere)
            {
                Append(", ");
            }
            else
            {
                AppendWithIndent("where ");
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
