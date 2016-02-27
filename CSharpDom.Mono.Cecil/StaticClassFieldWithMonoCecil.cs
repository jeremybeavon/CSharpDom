using System;
using System.Collections.Generic;
using CSharpDom.BaseClasses;
using CSharpDom.Mono.Cecil.Cil;
using CSharpDom.Mono.Cecil.Internal;
using System.Reflection;
using CSharpDom.Mono.Cecil.ConstantExpressions;
using CSharpDom.NotSupported;

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

        internal StaticClassFieldWithMonoCecil(ITypeWithMonoCecil declaringType, FieldInfo field)
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
            get { return new IFieldWithMonoCecil[] { this }; }
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
                if (field.FieldInfo.IsLiteral)
                {
                    return StaticClassFieldModifier.Const;
                }

                if (field.FieldInfo.IsInitOnly)
                {
                    return StaticClassFieldModifier.ReadOnly;
                }

                if (field.FieldInfo.IsVolatile())
                {
                    return StaticClassFieldModifier.Volatile;
                }
                
                return StaticClassFieldModifier.None;
            }
        }

        public string Name
        {
            get { return field.FieldInfo.Name; }
        }

        public override StaticClassMemberVisibilityModifier Visibility
        {
            get
            {
                FieldInfo fieldInfo = field.FieldInfo;
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
