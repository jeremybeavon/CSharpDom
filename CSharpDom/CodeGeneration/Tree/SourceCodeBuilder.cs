using System;
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

        private readonly SourceCodeTextBuilder textBuilder;
        private TypeReference currentType;
        private ClassPropertyAccessor currentClassPropertyGetAccessor;
        private string fieldComma;
        private StructPropertyAccessor currentStructPropertyGetAccessor;

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
                case MethodParameterModifier.This:
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
            AppendCommaSeparatedCollection(node.Fields, " ");
            Append(";");
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
            AppendMethodParameters(node.Parameters);
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
                fieldComma = string.Empty;
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

            Append("<");
            AppendCommaSeparatedCollection(node.GenericParameters, string.Empty);
            Append(">");
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
            if (node.AddBody.Count == 1)
            {
                Append(" {");
                node.AddBody[0].Accept(this);
                Append("}");
            }
            else
            {
                AppendBlock(node.AddBody);
            }

            if (node.RemoveBody.Count == 1)
            {
                Append(" {");
                node.RemoveBody[0].Accept(this);
                Append("}");
            }
            else
            {
                AppendBlock(node.RemoveBody);
            }
        }

        public override void Visit(ExpressionStatement node)
        {
            if (string.IsNullOrWhiteSpace(node.RawExpression))
            {
                throw new NotSupportedException();
            }

            AppendWithIndent(node.RawExpression);
            Append(";");
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
                else if (node.TypeConstraint != GenericParameteTypeConstraintModifier.None)
                {
                    AppendWithIndent("where " + node.Name + " : ");
                    hasWhere = true;
                    Append(node.TypeConstraint == GenericParameteTypeConstraintModifier.Class ? "class" : "struct");
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
            Append(ToString(node.InheritanceModifier));
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
            AppendIndent();
            if (node.IsNew)
            {
                Append("new ");
            }

            node.Type.Accept(this);
            Append(node.Name);
            Append(";");
        }

        public override void Visit(InterfaceMethod node)
        {
            AppendIndent();
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
            AppendIndent();
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
            AppendWithIndent(ToString(node.Modifier));
            node.Type.Accept(this);
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
            AppendWithIndent(ToString(node.Visibility));
            node.Type.Accept(this);
            Append(node.Name);
            if (node.Accessors != null)
            {
                node.Accessors.Accept(this);
            }
        }

        public override void Visit(StructFieldDeclaration node)
        {
            AppendWithIndent(ToString(node.Visibility));
            Append(ToString(node.Modifier));
            node.Type.Accept(this);
            AppendCommaSeparatedCollection(node.Fields, string.Empty);
        }

        public override void Visit(StructIndexer node)
        {
            AppendWithIndent(ToString(node.Visibility));
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

        public override void Visit(StructMethod node)
        {
            AppendWithIndent(ToString(node.Visibility));
            if (node.IsAsync)
            {
                Append("async ");
            }

            node.ReturnType.Accept(this);
            Append(node.Name);
            AppendGenericParameters(node.GenericParameters);
            AppendMethodParameters(node.Parameters);
            AppendGenericParameterConstraints(node.GenericParameters);
            AppendBlock(node.Body);
        }

        public override void Visit(StructNestedClass node)
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

        public override void Visit(StructNestedDelegate node)
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

        public override void Visit(StructNestedEnum node)
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

        public override void Visit(StructNestedInterface node)
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

        public override void Visit(StructNestedStruct node)
        {
            AppendWithIndent(ToString(node.Visibility));
            AppendPartial(node.IsPartial);
            Append(node.Name);
            AppendGenericParameters(node.GenericParameters);
            AppendCommaSeparatedCollection(node.Interfaces, " : ");
            AppendGenericParameterConstraints(node.GenericParameters);
            AppendTypeBody(node.Body, new TypeReference(node));
        }

        public override void Visit(StructProperty node)
        {
            AppendWithIndent(ToString(node.Visibility));
            Append(ToString(node.InheritanceModifier));
            node.Type.Accept(this);
            Append(node.Name);
            if (node.EmptyAccessors == null)
            {
                currentStructPropertyGetAccessor = node.GetAccessor;
                AppendBlock(new PropertyAccessors<StructPropertyAccessor>(node.GetAccessor, node.SetAccessor));
                currentStructPropertyGetAccessor = null;
            }
            else
            {
                node.EmptyAccessors.Accept(this);
            }
        }

        public override void Visit(StructPropertyAccessor node)
        {
            AppendWithIndent(ToString(node.Visibility));
            Append(currentStructPropertyGetAccessor == node ? GetText : SetText);
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
            AppendWithIndent(PublicText + StaticText);
            AppendUnaryOperatorTypeReference(node.ReturnType, node.OperatorType);
            Append(OperatorText);
            Append(ToString(node.OperatorType));
            Append("(");
            AppendUnaryOperatorTypeReference(node.ParameterType, node.OperatorType);
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

        protected void AppendWithIndent(string text)
        {
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
