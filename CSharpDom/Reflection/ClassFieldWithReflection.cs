using System;
using System.Collections.Generic;
using CSharpDom.BaseClasses;
using CSharpDom.Reflection.Emit;
using CSharpDom.Reflection.Internal;
using System.Reflection;

namespace CSharpDom.Reflection
{
    public sealed class ClassFieldWithReflection :
        AbstractClassField<
            AttributeWithReflection,
            ITypeWithReflection,
            ITypeReferenceWithReflection>
    {
        private readonly FieldWithReflection field;

        internal ClassFieldWithReflection(ITypeWithReflection declaringType, FieldInfo field)
        {
            this.field = new FieldWithReflection(declaringType, field);
        }

        public override IReadOnlyCollection<AttributeWithReflection> Attributes
        {
            get { return field.Attributes; }
        }

        public override ITypeWithReflection DeclaringType
        {
            get { return field.DeclaringType; }
        }

        public override ITypeReferenceWithReflection FieldType
        {
            get { return field.FieldType; }
        }

        public override ClassFieldModifier Modifier
        {
            get { return field.Modifier; }
        }

        public override string Name
        {
            get { return field.Name; }
        }

        public override ClassMemberVisibilityModifier Visibility
        {
            get
            {
                FieldInfo fieldInfo = field.FieldInfo;
                if (fieldInfo.IsPublic)
                {
                    return ClassMemberVisibilityModifier.Public;
                }

                if (fieldInfo.IsAssembly)
                {
                    return ClassMemberVisibilityModifier.Internal;
                }

                if (fieldInfo.IsFamilyOrAssembly)
                {
                    return ClassMemberVisibilityModifier.ProtectedInternal;
                }

                if (fieldInfo.IsFamily)
                {
                    return ClassMemberVisibilityModifier.Protected;
                }

                if (fieldInfo.IsPrivate)
                {
                    return ClassMemberVisibilityModifier.Private;
                }

                return ClassMemberVisibilityModifier.None;
            }
        }
    }
}
