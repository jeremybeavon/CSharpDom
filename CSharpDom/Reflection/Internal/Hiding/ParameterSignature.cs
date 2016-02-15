using System;
using System.Collections.Generic;
using CSharpDom.BaseClasses;
using CSharpDom.Common;
using CSharpDom.NotSupported;
using System.Reflection;

namespace CSharpDom.Reflection.Internal.Hiding
{
    internal sealed class ParameterSignature : AbstractMethodParameter<AttributeGroupNotSupported, ITypeReferenceWithReflection>,
        IIndexerParameter<AttributeGroupNotSupported, ITypeReferenceWithReflection>
    {
        private readonly ParameterModifier modifier;
        private readonly string name;
        private readonly ITypeReferenceWithReflection parameterType;

        public ParameterSignature(ParameterInfo parameter)
        {
            modifier = parameter.Modifier();
            name = string.Format("parameter{0}", parameter.Position + 1);
            parameterType = TypeReferenceWithReflectionFactory.CreateReference(parameter.ParameterType);
        }

        public override IReadOnlyCollection<AttributeGroupNotSupported> Attributes
        {
            get { return new AttributeGroupNotSupported[0]; }
        }

        public override ParameterModifier Modifier
        {
            get { return modifier; }
        }

        public override string Name
        {
            get { return name; }
        }

        public override ITypeReferenceWithReflection ParameterType
        {
            get { return parameterType; }
        }

        IndexerParameterModifier IHasModifier<IndexerParameterModifier>.Modifier
        {
            get { return Modifier == ParameterModifier.Params ? IndexerParameterModifier.Params : IndexerParameterModifier.None; }
        }
    }
}
