using System;
using System.Collections.Generic;
using CSharpDom.BaseClasses;
using System.Reflection;
using CSharpDom.Mono.Cecil.Internal;

namespace CSharpDom.Mono.Cecil.Internal
{
    internal sealed class FieldGroupWithMonoCecil : 
        AbstractFieldGroup<AttributeWithMonoCecil, ITypeWithMonoCecil, ITypeReferenceWithMonoCecil, IFieldWithMonoCecil>,
        IHasFieldInfo
    {
        private readonly ITypeWithMonoCecil declaringType;
        private readonly FieldInfo field;
        private readonly Lazy<Attributes> attributes;
        private readonly ITypeReferenceWithMonoCecil fieldType;

        internal FieldGroupWithMonoCecil(ITypeWithMonoCecil declaringType, FieldInfo field)
        {
            this.declaringType = declaringType;
            this.field = field;
            attributes = new Lazy<Attributes>(() => new Attributes(field));
            fieldType = TypeReferenceWithMonoCecilFactory.CreateReference(field.FieldType);
        }

        public override IReadOnlyCollection<AttributeWithMonoCecil> Attributes
        {
            get { return attributes.Value.AttributesWithMonoCecil; }
        }

        public override ITypeWithMonoCecil DeclaringType
        {
            get { return declaringType; }
        }

        public FieldInfo FieldInfo
        {
            get { return field; }
        }

        public override ITypeReferenceWithMonoCecil FieldType
        {
            get { return fieldType; }
        }

        public ClassFieldModifier Modifier
        {
            get
            {
                if (field.IsStatic)
                {
                    if (field.IsInitOnly)
                    {
                        return ClassFieldModifier.StaticReadOnly;
                    }

                    if (field.IsVolatile())
                    {
                        return ClassFieldModifier.StaticVolatile;
                    }

                    return ClassFieldModifier.Static;
                }

                if (field.IsInitOnly)
                {
                    return ClassFieldModifier.ReadOnly;
                }

                if (field.IsVolatile())
                {
                    return ClassFieldModifier.Volatile;
                }

                return ClassFieldModifier.None;
            }
        }
        
        public override IReadOnlyCollection<IFieldWithMonoCecil> Fields
        {
            get { return new IFieldWithMonoCecil[0]; }
        }

        /*public override ClassMemberVisibilityModifier Visibility
        {
            get
            {
                if (field.IsPublic)
                {
                    return ClassMemberVisibilityModifier.Public;
                }

                if (field.IsAssembly)
                {
                    return ClassMemberVisibilityModifier.Internal;
                }

                if (field.IsFamilyOrAssembly)
                {
                    return ClassMemberVisibilityModifier.ProtectedInternal;
                }

                if (field.IsFamily)
                {
                    return ClassMemberVisibilityModifier.Protected;
                }

                if (field.IsPrivate)
                {
                    return ClassMemberVisibilityModifier.Private;
                }

                return ClassMemberVisibilityModifier.None;
            }
        }*/
    }
}
