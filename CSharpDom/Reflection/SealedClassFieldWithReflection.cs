using System;
using System.Collections.Generic;
using CSharpDom.BaseClasses;
using CSharpDom.Reflection.Emit;
using CSharpDom.Reflection.Internal;
using System.Reflection;

namespace CSharpDom.Reflection
{
    public sealed class SealedClassFieldWithReflection :
        AbstractSealedClassField<
            AttributeWithReflection,
            ITypeWithReflection,
            ITypeReferenceWithReflection>
    {
        private readonly FieldGroupWithReflection field;

        internal SealedClassFieldWithReflection(ITypeWithReflection declaringType, FieldInfo field)
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

        public override SealedClassMemberVisibilityModifier Visibility
        {
            get
            {
                FieldInfo fieldInfo = field.FieldInfo;
                if (fieldInfo.IsPublic)
                {
                    return SealedClassMemberVisibilityModifier.Public;
                }

                if (fieldInfo.IsAssembly)
                {
                    return SealedClassMemberVisibilityModifier.Internal;
                }
                
                if (fieldInfo.IsPrivate)
                {
                    return SealedClassMemberVisibilityModifier.Private;
                }

                return SealedClassMemberVisibilityModifier.None;
            }
        }
    }
}
