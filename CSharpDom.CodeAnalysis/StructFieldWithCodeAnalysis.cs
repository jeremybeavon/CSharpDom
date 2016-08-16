using System;
using System.Collections.Generic;
using CSharpDom.BaseClasses;
using CSharpDom.CodeAnalysis.Internal;
using System.Reflection;
using CSharpDom.Mono.Cecil.ConstantExpressions;
using CSharpDom.NotSupported;
using Microsoft.CodeAnalysis.CSharp.Syntax;

namespace CSharpDom.CodeAnalysis
{
    public sealed class StructFieldWithCodeAnalysis :
        AbstractStructField<
            AttributeGroupWithCodeAnalysis,
            ITypeWithCodeAnalysis,
            ITypeReferenceWithCodeAnalysis,
            IFieldWithCodeAnalysis>,
        IFieldWithCodeAnalysis
    {
        private readonly FieldGroupWithCodeAnalysis field;

        internal StructFieldWithCodeAnalysis(ITypeWithCodeAnalysis declaringType, FieldDefinition field)
        {
            this.field = new FieldGroupWithCodeAnalysis(declaringType, field);
        }

        public override IReadOnlyCollection<AttributeGroupWithCodeAnalysis> Attributes
        {
            get { return field.Attributes; }
        }

        public override ITypeWithCodeAnalysis DeclaringType
        {
            get { return field.DeclaringType; }
        }

        public override IReadOnlyCollection<IFieldWithCodeAnalysis> Fields
        {
            get { return new IFieldWithCodeAnalysis[] { new InternalFieldWithCodeAnalysis(field.FieldDefinition) }; }
        }

        public override ITypeReferenceWithCodeAnalysis FieldType
        {
            get { return field.FieldType; }
        }

        public ExpressionNotSupported InitialValue
        {
            get { return new ExpressionNotSupported(); }
        }

        public override StructFieldModifier Modifier
        {
            get
            {
                switch (field.Modifier)
                {
                    case ClassFieldModifier.None:
                        return StructFieldModifier.None;
                    case ClassFieldModifier.ReadOnly:
                        return StructFieldModifier.ReadOnly;
                    case ClassFieldModifier.Static:
                        return StructFieldModifier.Static;
                    case ClassFieldModifier.StaticReadOnly:
                        return StructFieldModifier.StaticReadOnly;
                    case ClassFieldModifier.StaticVolatile:
                        return StructFieldModifier.StaticVolatile;
                    case ClassFieldModifier.Volatile:
                        return StructFieldModifier.Volatile;
                    default:
                        throw new NotSupportedException();
                }
            }
        }

        public string Name
        {
            get { return field.FieldDefinition.Name; }
        }

        public override StructMemberVisibilityModifier Visibility
        {
            get
            {
                FieldDefinition fieldInfo = field.FieldDefinition;
                if (fieldInfo.IsPublic)
                {
                    return StructMemberVisibilityModifier.Public;
                }

                if (fieldInfo.IsAssembly)
                {
                    return StructMemberVisibilityModifier.Internal;
                }
                
                if (fieldInfo.IsPrivate)
                {
                    return StructMemberVisibilityModifier.Private;
                }

                return StructMemberVisibilityModifier.None;
            }
        }
    }
}
