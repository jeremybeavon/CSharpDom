using System;
using System.Collections.Generic;
using CSharpDom.BaseClasses;
using CSharpDom.Reflection.Emit;
using CSharpDom.Reflection.Internal;
using System.Reflection;
using CSharpDom.Reflection.ConstantExpressions;
using CSharpDom.NotSupported;

namespace CSharpDom.Reflection
{
    public sealed class StructFieldWithReflection :
        AbstractStructField<
            AttributeWithReflection,
            ITypeWithReflection,
            ITypeReferenceWithReflection,
            IFieldWithReflection>,
        IFieldWithReflection
    {
        private readonly FieldGroupWithReflection field;

        internal StructFieldWithReflection(ITypeWithReflection declaringType, FieldInfo field)
        {
            this.field = new FieldGroupWithReflection(declaringType, field);
        }

        public override IReadOnlyCollection<AttributeWithReflection> Attributes
        {
            get { return field.Attributes; }
        }

        public override ITypeWithReflection DeclaringType
        {
            get { return field.DeclaringType; }
        }

        public override IReadOnlyCollection<IFieldWithReflection> Fields
        {
            get { return new IFieldWithReflection[] { this }; }
        }

        public override ITypeReferenceWithReflection FieldType
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
            get { return field.FieldInfo.Name; }
        }

        public override StructMemberVisibilityModifier Visibility
        {
            get
            {
                FieldInfo fieldInfo = field.FieldInfo;
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
