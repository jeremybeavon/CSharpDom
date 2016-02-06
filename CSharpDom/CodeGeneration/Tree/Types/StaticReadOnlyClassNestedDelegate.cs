using CSharpDom.BaseClasses;
using CSharpDom.Common;
using CSharpDom.NotSupported;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpDom.CodeGeneration.Tree.Types
{
    public sealed class ReadOnlyStaticClassNestedDelegate :
        AbstractStaticClassNestedDelegate<
            AttributeGroupNotSupported,
            IStaticType,
            ReadOnlyGenericParameterDeclaration,
            ReadOnlyTypeReference,
            ReadOnlyMethodParameter>
    {
        private readonly StaticClassNestedDelegate nestedDelegate;
        private readonly IReadOnlyList<ReadOnlyGenericParameterDeclaration> genericParameters;
        private readonly IReadOnlyList<ReadOnlyMethodParameter> parameters;
        private readonly ReadOnlyTypeReference returnType;

        public ReadOnlyStaticClassNestedDelegate(StaticClassNestedDelegate nestedDelegate)
        {
            this.nestedDelegate = nestedDelegate;
            genericParameters = ReadOnlyGenericParameterDeclaration.Create(nestedDelegate.GenericParameters);
            parameters = ReadOnlyMethodParameter.Create(nestedDelegate.Parameters);
            returnType = new ReadOnlyTypeReference(nestedDelegate.ReturnType);
        }

        public override IReadOnlyCollection<AttributeGroupNotSupported> Attributes
        {
            get { return new AttributeGroupNotSupported[0]; }
        }

        public override IStaticType DeclaringType
        {
            get { return null; }
        }

        public override IReadOnlyList<ReadOnlyGenericParameterDeclaration> GenericParameters
        {
            get { return genericParameters; }
        }

        public override string Name
        {
            get { return nestedDelegate.Name; }
        }

        public override IReadOnlyList<ReadOnlyMethodParameter> Parameters
        {
            get { return parameters; }
        }

        public override ReadOnlyTypeReference ReturnType
        {
            get { return returnType; }
        }

        public override StaticClassMemberVisibilityModifier Visibility
        {
            get { return nestedDelegate.Visibility; }
        }
    }
}
