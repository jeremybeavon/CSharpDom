using CSharpDom.BaseClasses;
using CSharpDom.Reflection.Internal;
using System;
using System.Collections.Generic;
using System.Reflection;

namespace CSharpDom.Reflection
{
    public sealed class ParameterWithReflection : AbstractParameter<AttributeWithReflection, ITypeReferenceWithReflection>
    {
        private readonly ParameterInfo parameter;
        private readonly Lazy<Attributes> attributes;

        internal ParameterWithReflection(ParameterInfo parameter)
        {
            this.parameter = parameter;
            attributes = new Lazy<Attributes>(() => new Attributes(parameter));
        }

        public override IReadOnlyCollection<AttributeWithReflection> Attributes
        {
            get { return attributes.Value.AttributesWithReflection; }
        }

        public override MethodParameterModifier Modifier
        {
            get
            {
                throw new NotImplementedException();
            }
        }

        public override string Name
        {
            get { return parameter.Name; }
        }

        public override ITypeReferenceWithReflection ParameterType
        {
            get
            {
                throw new NotImplementedException();
            }
        }
    }
}
