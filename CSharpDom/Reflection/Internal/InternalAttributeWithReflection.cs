using CSharpDom.BaseClasses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace CSharpDom.Reflection.Internal
{
    internal sealed class InternalAttributeWithReflection :
        AbstractAttribute<ClassReferenceWithReflection, UnnamedAttributeValueWithReflection, NamedAttributeValueWithReflection>,
        IAttributeWithReflection
    {
        private readonly ClassReferenceWithReflection attributeType;
        private readonly IReadOnlyCollection<NamedAttributeValueWithReflection> namedAttributeValues;
        private readonly IReadOnlyList<UnnamedAttributeValueWithReflection> unnamedAttributeValues;

        internal InternalAttributeWithReflection(CustomAttributeData attribute)
        {
            attributeType = new ClassReferenceWithReflection(attribute.AttributeType);
            namedAttributeValues = attribute.NamedArguments.Select(value => new NamedAttributeValueWithReflection(value)).ToList();
            unnamedAttributeValues = attribute.ConstructorArguments.Select(value => new UnnamedAttributeValueWithReflection(value)).ToList();
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

        /*public void Accept(IReflectionVisitor visitor)
        {
            visitor.VisitAttributeWithReflection(this);
        }

        public void AcceptChildren(IReflectionVisitor visitor)
        {
            AcceptChildren(new ForwardingGenericVisitor(visitor));
        }*/
    }
}
