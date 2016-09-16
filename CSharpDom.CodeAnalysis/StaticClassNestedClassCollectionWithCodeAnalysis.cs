using System;
using System.Collections.Generic;
using CSharpDom.Common;
using CSharpDom.Editable;
using CSharpDom.NotSupported;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using System.Linq;

namespace CSharpDom.CodeAnalysis
{
    public sealed class StaticClassNestedClassCollectionWithCodeAnalysis :
        EditableStaticClassNestedClassCollection<
            StaticClassNestedClassWithCodeAnalysis,
            StaticClassNestedAbstractClassWithCodeAnalysis,
            StaticClassNestedSealedClassWithCodeAnalysis,
            StaticClassNestedStaticClassWithCodeAnalysis,
            PartialClassCollectionNotSupported>
    {
        private readonly StaticTypeWithCodeAnalysis type;
        private readonly StaticTypeMemberListWrapper<StaticClassNestedClassWithCodeAnalysis, ClassDeclarationSyntax> classes;
        private readonly StaticTypeMemberListWrapper<
            StaticClassNestedAbstractClassWithCodeAnalysis,
            ClassDeclarationSyntax> abstractClasses;
        private readonly StaticTypeMemberListWrapper<
            StaticClassNestedSealedClassWithCodeAnalysis,
            ClassDeclarationSyntax> sealedClasses;

        internal StaticClassNestedClassCollectionWithCodeAnalysis(StaticTypeWithCodeAnalysis type)
        {
            this.type = type;
            classes = new StaticTypeMemberListWrapper<StaticClassNestedClassWithCodeAnalysis, ClassDeclarationSyntax>(
                type.Node,
                () => new StaticClassNestedClassWithCodeAnalysis());
            abstractClasses = new StaticTypeMemberListWrapper<StaticClassNestedAbstractClassWithCodeAnalysis, ClassDeclarationSyntax>(
                type.Node,
                () => new StaticClassNestedAbstractClassWithCodeAnalysis());
            sealedClasses = new StaticTypeMemberListWrapper<StaticClassNestedSealedClassWithCodeAnalysis, ClassDeclarationSyntax>(
                type.Node,
                () => new StaticClassNestedSealedClassWithCodeAnalysis());
        }

        public override ICollection<StaticClassNestedAbstractClassWithCodeAnalysis> AbstractClasses
        {
            get { return abstractClasses; }
            set { type.Members.CombineList(nameof(AbstractClasses), value.Select(item => item.Syntax)); }
        }

        public override ICollection<StaticClassNestedClassWithCodeAnalysis> Classes
        {
            get { return classes; }
            set { type.Members.CombineList(nameof(Classes), value.Select(item => item.Syntax)); }
        }

        public override ICollection<StaticClassNestedSealedClassWithCodeAnalysis> SealedClasses
        {
            get { return sealedClasses; }
            set { type.Members.CombineList(nameof(SealedClasses), value.Select(item => item.Syntax)); }
        }

        public override ICollection<StaticClassNestedStaticClassWithCodeAnalysis> StaticClasses
        {
            get
            {
                throw new NotImplementedException();
            }

            set
            {
                throw new NotImplementedException();
            }
        }

        public override PartialClassCollectionNotSupported PartialClasses
        {
            get
            {
                throw new NotImplementedException();
            }

            set
            {
                throw new NotImplementedException();
            }
        }
    }
}
