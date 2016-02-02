using CSharpDom.BaseClasses;
using CSharpDom.Reflection.Internal;
using System;
using System.Collections.Generic;
using System.Reflection;
using System.Runtime.CompilerServices;

namespace CSharpDom.Reflection
{
    public sealed class ParameterWithReflection :
        AbstractParameter<AttributeWithReflection, ITypeReferenceWithReflection>,
        IHasParameterInfo//,
        //IVisitable<IReflectionVisitor>
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

        public override ParameterModifier Modifier
        {
            get
            {
                if (parameter.IsDefined(typeof(ExtensionAttribute)))
                {
                    return ParameterModifier.This;
                }

                if (parameter.IsOut)
                {
                    return ParameterModifier.Out;
                }

                if (parameter.ParameterType.IsByRef)
                {
                    return ParameterModifier.Ref;
                }

                if (parameter.IsDefined(typeof(ParamArrayAttribute)))
                {
                    return ParameterModifier.Params;
                }

                return ParameterModifier.None;
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

        public ParameterInfo ParameterInfo
        {
            get { return parameter; }
        }

        /*public void Accept(IReflectionVisitor visitor)
        {
            visitor.VisitParameterWithReflection(this);
        }

        public void AcceptChildren(IReflectionVisitor visitor)
        {
            AcceptChildren(new ForwardingGenericVisitor(visitor));
        }*/
    }
}
