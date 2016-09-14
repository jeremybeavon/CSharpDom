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
        private readonly StaticTypeMemberListWrapper<
            ClassTypeWithCodeAnalysis,
            StaticClassNestedClassWithCodeAnalysis,
            ClassDeclarationSyntax> classes;
        private readonly StaticTypeMemberListWrapper<
            ClassTypeWithCodeAnalysis,
            StaticClassNestedAbstractClassWithCodeAnalysis,
            ClassDeclarationSyntax> abstractClasses;
        private readonly StaticTypeMemberListWrapper<
            ClassTypeWithCodeAnalysis,
            StaticClassNestedSealedClassWithCodeAnalysis,
            ClassDeclarationSyntax> sealedClasses;

        internal StaticClassNestedClassCollectionWithCodeAnalysis(StaticTypeWithCodeAnalysis type)
        {
            this.type = type;
            classes = new StaticTypeMemberListWrapper<ClassTypeWithCodeAnalysis, StaticClassNestedClassWithCodeAnalysis, ClassDeclarationSyntax>(
                type.Node,
                () => new StaticClassNestedClassWithCodeAnalysis());
            abstractClasses = new StaticTypeMemberListWrapper<ClassTypeWithCodeAnalysis, StaticClassNestedAbstractClassWithCodeAnalysis, ClassDeclarationSyntax>(
                type.Node,
                () => new StaticClassNestedAbstractClassWithCodeAnalysis());
            sealedClasses = new StaticTypeMemberListWrapper<ClassTypeWithCodeAnalysis, StaticClassNestedSealedClassWithCodeAnalysis, ClassDeclarationSyntax>(
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

        internal IChildCollection<ClassTypeWithCodeAnalysis, ClassDeclarationSyntax> AbstractClassList
        {
            get { return abstractClasses; }
        }

        internal IChildCollection<ClassTypeWithCodeAnalysis, ClassDeclarationSyntax> ClassList
        {
            get { return classes; }
        }

        internal IChildCollection<ClassTypeWithCodeAnalysis, ClassDeclarationSyntax> SealedClassList
        {
            get { return sealedClasses; }
        }
    }
}
