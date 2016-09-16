using System;
using System.Collections.Generic;
using CSharpDom.Editable;
using CSharpDom.NotSupported;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using System.Linq;

namespace CSharpDom.CodeAnalysis
{
    public sealed class ClassCollectionWithCodeAnalysis :
        EditableClassCollection<
            ClassWithCodeAnalysis,
            AbstractClassWithCodeAnalysis,
            SealedClassWithCodeAnalysis,
            StaticClassWithCodeAnalysis,
            PartialClassCollectionNotSupported>
    {
        private readonly IMemberList members;
        private readonly ICollection<AbstractClassWithCodeAnalysis> abstractClasses;
        private readonly ICollection<ClassWithCodeAnalysis> classes;
        private readonly ICollection<SealedClassWithCodeAnalysis> sealedClasses;
        private readonly ICollection<StaticClassWithCodeAnalysis> staticClasses;

        internal ClassCollectionWithCodeAnalysis(NamespaceWithCodeAnalysis @namespace)
        {
            abstractClasses = new NamespaceMemberListWrapper<AbstractClassWithCodeAnalysis, ClassDeclarationSyntax>(
                @namespace.Node,
                () => new AbstractClassWithCodeAnalysis());
            classes = new NamespaceMemberListWrapper<ClassWithCodeAnalysis, ClassDeclarationSyntax>(
                @namespace.Node,
                () => new ClassWithCodeAnalysis());
            sealedClasses = new NamespaceMemberListWrapper<SealedClassWithCodeAnalysis, ClassDeclarationSyntax>(
                @namespace.Node,
                () => new SealedClassWithCodeAnalysis());
            staticClasses = new NamespaceMemberListWrapper<StaticClassWithCodeAnalysis, ClassDeclarationSyntax>(
                @namespace.Node,
                () => new StaticClassWithCodeAnalysis());
        }

        public override ICollection<AbstractClassWithCodeAnalysis> AbstractClasses
        {
            get { return abstractClasses; }
            set { members.CombineList(nameof(AbstractClasses), value.Select(item => item.Syntax)); }
        }

        public override ICollection<ClassWithCodeAnalysis> Classes
        {
            get { return classes; }
            set { members.CombineList(nameof(Classes), value.Select(item => item.Syntax)); }
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

        public override ICollection<SealedClassWithCodeAnalysis> SealedClasses
        {
            get { return sealedClasses; }
            set { members.CombineList(nameof(SealedClasses), value.Select(item => item.Syntax)); }
        }

        public override ICollection<StaticClassWithCodeAnalysis> StaticClasses
        {
            get { return staticClasses; }
            set { members.CombineList(nameof(StaticClasses), value.Select(item => item.Syntax)); }
        }
    }
}
