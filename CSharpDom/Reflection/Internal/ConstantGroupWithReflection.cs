using System;
using System.Collections.Generic;
using CSharpDom.BaseClasses;
using System.Reflection;
using CSharpDom.Reflection.Internal;
using CSharpDom.Reflection.ConstantExpressions;

namespace CSharpDom.Reflection.Internal
{
    internal sealed class ConstantGroupWithReflection :
        AbstractConstantGroup<AttributeWithReflection, ITypeWithReflection, ITypeReferenceWithReflection, IConstantWithReflection>,
        IConstantWithReflection,
        IHasFieldInfo
    {
        private readonly ITypeWithReflection declaringType;
        private readonly FieldInfo field;
        private readonly Lazy<Attributes> attributes;
        private readonly ITypeReferenceWithReflection fieldType;
        private readonly Lazy<IConstantExpressionWithReflection> constantValue;

        internal ConstantGroupWithReflection(ITypeWithReflection declaringType, FieldInfo field)
        {
            this.declaringType = declaringType;
            this.field = field;
            attributes = new Lazy<Attributes>(() => new Attributes(field));
            fieldType = TypeReferenceWithReflectionFactory.CreateReference(field.FieldType, field);
            constantValue = new Lazy<IConstantExpressionWithReflection>(
                () => ConstantExpressionFactory.CreateExpression(field.GetValue(null)));
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
        
        public override IReadOnlyCollection<IConstantWithReflection> Constants
        {
            get { return new IConstantWithReflection[0]; }
        }

        public string Name
        {
            get { return field.Name; }
        }

        public IConstantExpressionWithReflection ConstantValue
        {
            get { return constantValue.Value; }
        }
    }
}
