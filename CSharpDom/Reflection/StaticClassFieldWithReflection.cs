using System;
using System.Collections.Generic;
using CSharpDom.BaseClasses;
using CSharpDom.Reflection.Emit;
using CSharpDom.Reflection.Internal;
using System.Reflection;

namespace CSharpDom.Reflection
{
    public sealed class StaticClassFieldWithReflection :
        AbstractStaticClassField<
            AttributeWithReflection,
            ITypeWithReflection,
            ITypeReferenceWithReflection>
    {
        private readonly FieldGroupWithReflection field;

        internal StaticClassFieldWithReflection(ITypeWithReflection declaringType, FieldInfo field)
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

        public override string Name
        {
            get { return field.Name; }
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
