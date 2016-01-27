using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using CSharpDom.BaseClasses;
using CSharpDom.Common;
using CSharpDom.Reflection.Internal;

namespace CSharpDom.Reflection
{
    public class AttributeWithReflection :
        AbstractAttribute<ClassReferenceWithReflection, UnnamedAttributeValueWithReflection, NamedAttributeValueWithReflection>,
        IAttributeGroup<AttributeWithReflection>,
        IVisitable<IReflectionVisitor>
    {
        private readonly ClassReferenceWithReflection attributeType;
        private readonly IReadOnlyCollection<NamedAttributeValueWithReflection> namedAttributeValues;
        private readonly IReadOnlyList<UnnamedAttributeValueWithReflection> unnamedAttributeValues;

        internal AttributeWithReflection(CustomAttributeData attribute)
        {
            attributeType = new ClassReferenceWithReflection(attribute.AttributeType);
            namedAttributeValues = attribute.NamedArguments.Select(value => new NamedAttributeValueWithReflection(value)).ToList();
            unnamedAttributeValues = attribute.ConstructorArguments.Select(value => new UnnamedAttributeValueWithReflection(value)).ToList();
        }

        public IReadOnlyCollection<AttributeWithReflection> Attributes
        {
            get { return new AttributeWithReflection[] { this }; }
        }

        public override ClassReferenceWithReflection AttributeType
        {
            get { return attributeType; }
        }

        public override IReadOnlyCollection<NamedAttributeValueWithReflection> NamedValues
        {
            get { return namedAttributeValues; }
        }

        public override IReadOnlyList<UnnamedAttributeValueWithReflection> UnnamedValues
        {
            get { return unnamedAttributeValues; }
        }

        public void Accept(IReflectionVisitor visitor)
        {
            visitor.VisitAttributeWithReflection(this);
        }

        public void AcceptChildren(IReflectionVisitor visitor)
        {
            AcceptChildren(new ForwardingGenericVisitor(visitor));
        }
    }
}
