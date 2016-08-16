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
    public sealed class StaticClassFieldWithCodeAnalysis :
        AbstractStaticClassField<
            AttributeGroupWithCodeAnalysis,
            ITypeWithCodeAnalysis,
            ITypeReferenceWithCodeAnalysis,
            IFieldWithCodeAnalysis>,
        IFieldWithCodeAnalysis
    {
        private readonly FieldGroupWithCodeAnalysis field;

        internal StaticClassFieldWithCodeAnalysis(ITypeWithCodeAnalysis declaringType, FieldDefinition field)
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
