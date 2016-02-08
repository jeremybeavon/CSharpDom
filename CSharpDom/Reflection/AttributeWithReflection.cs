using System.Collections.Generic;
using System.Reflection;
using CSharpDom.BaseClasses;
using CSharpDom.Reflection.Internal;

namespace CSharpDom.Reflection
{
    public class AttributeWithReflection :
        AbstractAttributeGroup<IAttributeWithReflection>,
        IAttributeWithReflection//,
        //IVisitable<IReflectionVisitor>
    {
        private readonly IAttributeWithReflection attribute;

        internal AttributeWithReflection(CustomAttributeData attribute)
        {
            this.attribute = new InternalAttributeWithReflection(attribute);
        }

        public override IReadOnlyCollection<IAttributeWithReflection> Attributes
        {
            get { return new IAttributeWithReflection[] { attribute }; }
        }

        public ClassReferenceWithReflection AttributeType
        {
            get { return attribute.AttributeType; }
        }

        public IReadOnlyCollection<NamedAttributeValueWithReflection> NamedValues
        {
            get { return attribute.NamedValues; }
        }

        public IReadOnlyList<UnnamedAttributeValueWithReflection> UnnamedValues
        {
            get { return attribute.UnnamedValues; }
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
