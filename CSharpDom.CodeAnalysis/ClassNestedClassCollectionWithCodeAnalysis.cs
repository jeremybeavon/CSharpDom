using System;
using System.Collections.Generic;
using CSharpDom.Common;
using CSharpDom.Editable;
using CSharpDom.NotSupported;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using System.Linq;

namespace CSharpDom.CodeAnalysis
{
    public sealed class ClassNestedClassCollectionWithCodeAnalysis :
        EditableClassNestedClassCollection<
            ClassNestedClassWithCodeAnalysis,
            ClassNestedAbstractClassWithCodeAnalysis,
            ClassNestedSealedClassWithCodeAnalysis,
            IClassNestedStaticClass,
            PartialClassCollectionNotSupported>
    {
        private readonly ClassTypeWithCodeAnalysis classType;
        private readonly ClassMemberListWrapper<
            ClassTypeWithCodeAnalysis,
            ClassNestedClassWithCodeAnalysis,
            ClassDeclarationSyntax> classes;
        private readonly ClassMemberListWrapper<
            ClassTypeWithCodeAnalysis,
            ClassNestedAbstractClassWithCodeAnalysis,
            ClassDeclarationSyntax> abstractClasses;
        private readonly ClassMemberListWrapper<
            ClassTypeWithCodeAnalysis,
            ClassNestedSealedClassWithCodeAnalysis,
            ClassDeclarationSyntax> sealedClasses;

        internal ClassNestedClassCollectionWithCodeAnalysis(ClassTypeWithCodeAnalysis classType)
        {
            this.classType = classType;
            classes = new ClassMemberListWrapper<ClassTypeWithCodeAnalysis, ClassNestedClassWithCodeAnalysis, ClassDeclarationSyntax>(
                classType.Node,
                parent => new ClassNestedClassWithCodeAnalysis(parent),
                (child, parent) => child.Class.Class.SetClassParent(parent, ClassType.Normal));
            abstractClasses = new ClassMemberListWrapper<ClassTypeWithCodeAnalysis, ClassNestedAbstractClassWithCodeAnalysis, ClassDeclarationSyntax>(
                classType.Node,
                parent => new ClassNestedAbstractClassWithCodeAnalysis(parent),
                (child, parent) => child.Class.Class.Type.SetClassParent(parent, ClassType.Abstract));
            sealedClasses = new ClassMemberListWrapper<ClassTypeWithCodeAnalysis, ClassNestedSealedClassWithCodeAnalysis, ClassDeclarationSyntax>(
                classType.Node,
                parent => new ClassNestedSealedClassWithCodeAnalysis(parent),
                (child, parent) => child.Class.Class.Type.SetClassParent(parent, ClassType.Sealed));
        }

        public override ICollection<ClassNestedAbstractClassWithCodeAnalysis> AbstractClasses
        {
            get { return abstractClasses; }
            set { classType.Members.CombineList(nameof(AbstractClasses), value.Select(item => item.Syntax)); }
        }

        public override ICollection<ClassNestedClassWithCodeAnalysis> Classes
        {
            get { return classes; }
            set { classType.Members.CombineList(nameof(Classes), value.Select(item => item.Syntax)); }
        }

        public override ICollection<ClassNestedSealedClassWithCodeAnalysis> SealedClasses
        {
            get { return sealedClasses; }
            set { classType.Members.CombineList(nameof(SealedClasses), value.Select(item => item.Syntax)); }
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
