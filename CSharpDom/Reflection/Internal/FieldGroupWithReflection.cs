using System;
using System.Collections.Generic;
using CSharpDom.BaseClasses;
using System.Reflection;
using CSharpDom.Reflection.Internal;

namespace CSharpDom.Reflection.Internal
{
    internal sealed class FieldGroupWithReflection : 
        AbstractFieldGroup<AttributeWithReflection, ITypeWithReflection, ITypeReferenceWithReflection, IFieldWithReflection>,
        IHasFieldInfo
    {
        private readonly ITypeWithReflection declaringType;
        private readonly FieldInfo field;
        private readonly Lazy<Attributes> attributes;
        private readonly ITypeReferenceWithReflection fieldType;

        internal FieldGroupWithReflection(ITypeWithReflection declaringType, FieldInfo field)
        {
            this.declaringType = declaringType;
            this.field = field;
            attributes = new Lazy<Attributes>(() => new Attributes(field));
            fieldType = TypeReferenceWithReflectionFactory.CreateReference(field.FieldType, field);
        }

        public override IReadOnlyCollection<AttributeWithReflection> Attributes
        {
            get { return attributes.Value.AttributesWithReflection; }
        }

        public override ITypeWithReflection DeclaringType
        {
            get { return declaringType; }
        }

        public FieldInfo FieldInfo
        {
            get { return field; }
        }

        public override ITypeReferenceWithReflection FieldType
        {
            get { return fieldType; }
        }

        public ClassFieldModifier Modifier
        {
            get
            {
                ClassFieldModifier modifier = NonNewModifier;
                IInternalTypeWithReflection internalType = declaringType as IInternalTypeWithReflection;
                if (internalType == null || !internalType.HiddenMembersAnalyzer.IsFieldHidden(field))
                {
                    return modifier;
                }

                switch (modifier)
                {
                    case ClassFieldModifier.None:
                        return ClassFieldModifier.New;
                    case ClassFieldModifier.Static:
                        return ClassFieldModifier.NewStatic;
                    case ClassFieldModifier.StaticReadOnly:
                        return ClassFieldModifier.NewStaticReadOnly;
                    case ClassFieldModifier.StaticVolatile:
                        return ClassFieldModifier.NewStaticVolatile;
                    case ClassFieldModifier.Volatile:
                        return ClassFieldModifier.NewVolatile;
                    default:
                        throw new InvalidOperationException();
                }
            }
        }
        
        public override IReadOnlyCollection<IFieldWithReflection> Fields
        {
            get { return new IFieldWithReflection[0]; }
        }

        private ClassFieldModifier NonNewModifier
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
    }
}
