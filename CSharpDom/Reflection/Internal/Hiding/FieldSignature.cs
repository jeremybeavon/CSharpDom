using CSharpDom.BaseClasses;
using CSharpDom.Common;
using CSharpDom.NotSupported;
using System.Collections.Generic;
using System.Reflection;

namespace CSharpDom.Reflection.Internal.Hiding
{
    internal sealed class FieldSignature : AbstractField<AttributeGroupNotSupported, IType, ITypeReferenceWithReflection>
    {
        private readonly FieldInfo field;
        private readonly ITypeReferenceWithReflection fieldType;

        public FieldSignature(FieldInfo field)
        {
            this.field = field;
            fieldType = TypeReferenceWithReflectionFactory.CreateReference(field.FieldType);
        }

        public override IReadOnlyCollection<AttributeGroupNotSupported> Attributes
        {
            get { return new AttributeGroupNotSupported[0]; }
        }

        public override IType DeclaringType
        {
            get { return null; }
        }

        public override ITypeReferenceWithReflection FieldType
        {
            get { return fieldType; }
        }

        public override string Name
        {
            get { return field.Name; }
        }
    }
}
