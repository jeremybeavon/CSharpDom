using System;
using System.Collections.Generic;
using CSharpDom.BaseClasses;
using CSharpDom.Mono.Cecil.Cil;
using CSharpDom.Mono.Cecil.Internal;
using System.Reflection;
using CSharpDom.Mono.Cecil.ConstantExpressions;
using CSharpDom.NotSupported;
using Mono.Cecil;

namespace CSharpDom.Mono.Cecil
{
    public sealed class StructFieldWithMonoCecil :
        AbstractStructField<
            AttributeWithMonoCecil,
            ITypeWithMonoCecil,
            ITypeReferenceWithMonoCecil,
            IFieldWithMonoCecil>,
        IFieldWithMonoCecil
    {
        private readonly FieldGroupWithMonoCecil field;

        internal StructFieldWithMonoCecil(ITypeWithMonoCecil declaringType, FieldDefinition field)
        {
            this.field = new FieldGroupWithMonoCecil(declaringType, field);
        }

        public override IReadOnlyCollection<AttributeWithMonoCecil> Attributes
        {
            get { return field.Attributes; }
        }

        public override ITypeWithMonoCecil DeclaringType
        {
            get { return field.DeclaringType; }
        }

        public override IReadOnlyCollection<IFieldWithMonoCecil> Fields
        {
            get { return new IFieldWithMonoCecil[] { new InternalFieldWithMonoCecil(field.FieldDefinition) }; }
        }

        public override ITypeReferenceWithMonoCecil FieldType
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
