using System;
using System.Collections.Generic;
using System.Reflection;
using CSharpDom.BaseClasses;
using CSharpDom.Reflection.Internal;

namespace CSharpDom.Reflection
{
    public sealed class ConstructorWithReflection :
        AbstractConstructor<AttributeWithReflection, ITypeWithReflection, ParameterWithReflection>
    {
        private readonly ITypeWithReflection declaringType;
        private readonly Lazy<Attributes> attributes;
        private readonly Lazy<Parameters> parameters;

        internal ConstructorWithReflection(ITypeWithReflection declaringType, ConstructorInfo constructor)
        {
            this.declaringType = declaringType;
            attributes = new Lazy<Attributes>(() => new Attributes(constructor));
            parameters = new Lazy<Parameters>(() => new Parameters(constructor));
        }

        public override IReadOnlyCollection<AttributeWithReflection> Attributes
        {
            get { return attributes.Value.AttributesWithReflection; }
        }

        public override ITypeWithReflection DeclaringType
        {
            get { return declaringType; }
        }

        public override IReadOnlyList<ParameterWithReflection> Parameters
        {
            get { return parameters.Value.ParametersWithReflection; }
        }
    }
}
