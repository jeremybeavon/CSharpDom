using System;
using System.Collections.Generic;
using System.Reflection;
using CSharpDom.BaseClasses;
using CSharpDom.Reflection.Emit;
using CSharpDom.Reflection.Internal;

namespace CSharpDom.Reflection.Internal
{
    internal sealed class ConstructorWithReflection :
        AbstractConstructor<
            AttributeWithReflection,
            ITypeWithReflection,
            ParameterWithReflection,
            ILMethodBodyWithReflectionEmit>,
        IHasConstructorInfo
    {
        private readonly ITypeWithReflection declaringType;
        private readonly ConstructorInfo constructor;
        private readonly Lazy<Attributes> attributes;
        private readonly Lazy<Parameters> parameters;
        private readonly Lazy<ILMethodBodyWithReflectionEmit> body;

        internal ConstructorWithReflection(ITypeWithReflection declaringType, ConstructorInfo constructor)
        {
            this.declaringType = declaringType;
            this.constructor = constructor;
            attributes = new Lazy<Attributes>(() => new Attributes(constructor));
            parameters = new Lazy<Parameters>(() => new Parameters(constructor));
            body = new Lazy<ILMethodBodyWithReflectionEmit>(() => new ILMethodBodyWithReflectionEmit(constructor));
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

        public ConstructorInfo ConstructorInfo
        {
            get { return constructor; }
        }

        public override ILMethodBodyWithReflectionEmit Body
        {
            get { return body.Value; }
        }
    }
}
