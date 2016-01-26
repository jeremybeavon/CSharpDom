using CSharpDom.BaseClasses;
using CSharpDom.Reflection.Internal;
using System;
using System.Collections.Generic;
using System.Reflection;
using System.Runtime.CompilerServices;

namespace CSharpDom.Reflection
{
    public sealed class ParameterWithReflection : AbstractParameter<AttributeWithReflection, ITypeReferenceWithReflection>
    {
        private readonly ParameterInfo parameter;
        private readonly Lazy<Attributes> attributes;
        private readonly ITypeReferenceWithReflection parameterType;

        internal ParameterWithReflection(ParameterInfo parameter)
        {
            this.parameter = parameter;
            attributes = new Lazy<Attributes>(() => new Attributes(parameter));
            parameterType = TypeReferenceWithReflectionFactory.CreateReference(parameter.ParameterType);
        }

        public override IReadOnlyCollection<AttributeWithReflection> Attributes
        {
            get { return attributes.Value.AttributesWithReflection; }
        }

        public override MethodParameterModifier Modifier
        {
            get
            {
                if (parameter.IsDefined(typeof(ExtensionAttribute)))
                {
                    return MethodParameterModifier.This;
                }

                if (parameter.IsOut)
                {
                    return MethodParameterModifier.Out;
                }

                if (parameter.ParameterType.IsByRef)
                {
                    return MethodParameterModifier.Ref;
                }

                if (parameter.IsDefined(typeof(ParamArrayAttribute)))
                {
                    return MethodParameterModifier.Params;
                }

                return MethodParameterModifier.None;
            }
        }

        public override string Name
        {
            get { return parameter.Name; }
        }

        public override ITypeReferenceWithReflection ParameterType
        {
            get { return parameterType; }
        }
    }
}
