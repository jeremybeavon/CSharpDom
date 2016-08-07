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
    public sealed class StaticClassFieldWithMonoCecil :
        AbstractStaticClassField<
            AttributeWithMonoCecil,
            ITypeWithMonoCecil,
            ITypeReferenceWithMonoCecil,
            IFieldWithMonoCecil>,
        IFieldWithMonoCecil
    {
        private readonly FieldGroupWithMonoCecil field;

        internal StaticClassFieldWithMonoCecil(ITypeWithMonoCecil declaringType, FieldDefinition field)
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

        public override StaticClassFieldModifier Modifier
        {
            get
            {
                if (field.FieldDefinition.IsInitOnly)
                {
                    return StaticClassFieldModifier.ReadOnly;
                }

                if (field.FieldDefinition.IsVolatile())
                {
                    return StaticClassFieldModifier.Volatile;
                }
                
                return StaticClassFieldModifier.None;
            }
        }

        public string Name
        {
            get { return field.FieldDefinition.Name; }
        }

        public override StaticClassMemberVisibilityModifier Visibility
        {
            get
            {
                FieldDefinition fieldInfo = field.FieldDefinition;
                if (fieldInfo.IsPublic)
                {
                    return StaticClassMemberVisibilityModifier.Public;
                }

                if (fieldInfo.IsAssembly)
                {
                    return StaticClassMemberVisibilityModifier.Internal;
                }
                
                if (fieldInfo.IsPrivate)
                {
                    return StaticClassMemberVisibilityModifier.Private;
                }

                return StaticClassMemberVisibilityModifier.None;
            }
        }
    }
}
