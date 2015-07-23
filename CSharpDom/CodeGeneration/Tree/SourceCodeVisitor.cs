using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpDom.CodeGeneration.Tree
{
    public class SourceCodeVisitor : CodeGenerationVisitor
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

        // Field modifier text
        public const string ConstText = "const ";
        public const string ReadOnlyText = "readonly ";
        public const string VolatileText = "volatile ";

        // Enum base type text
        public const string ByteText = " : byte";
        public const string SByteText = " : sbyte";
        public const string ShortText = " : short";
        public const string UShortText = " : ushort";
        public const string IntText = " : int";
        public const string UIntText = " : uint";
        public const string LongText = " : long";
        public const string ULongText = " : ulong";

        private readonly SourceCodeTextBuilder textBuilder;

        public SourceCodeVisitor()
        {
            textBuilder = new SourceCodeTextBuilder();
        }

        public SourceCodeVisitor(SourceCodeTextBuilder textBuilder)
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
            throw new NotImplementedException();
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
            if (node.IsPartial)
            {
                Append("partial ");
            }

            Append(node.Name);
            AppendGenericParameters(node.GenericParameters);
            if (node.BaseClass != null)
            {
                Append(" : ");
                node.BaseClass.Accept(this);
            }

            AppendCommaSeparatedCollection(node.Interfaces, node.BaseClass == null ? " : " : ", ");
            node.GenericParameters.AcceptIfNotNull(this);
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
            node.GenericParameters.AcceptIfNotNull(this);
            AppendBlock(node.Body);
        }

        public override void Visit(ClassNestedClass node)
        {
            AppendWithIndent(ToString(node.Visibility));
            Append(ToString(node.InheritanceModifier));
            if (node.IsPartial)
            {
                Append("partial ");
            }

            Append(node.Name);
            AppendGenericParameters(node.GenericParameters);
            if (node.BaseClass != null)
            {
                Append(" : ");
                node.BaseClass.Accept(this);
            }

            AppendCommaSeparatedCollection(node.Interfaces, node.BaseClass == null ? " : " : ", ");
            node.GenericParameters.AcceptIfNotNull(this);
            AppendBlock(node.Body);
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
        }

        public override void Visit(ClassNestedEnum node)
        {
            AppendWithIndent(ToString(node.Visibility));
            Append(EnumText);
            Append(node.Name);
            Append(ToString(node.BaseType));
            using (IncrementIndent())
            {
                node.Fields.Accept(this);
            }
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
    }
}
