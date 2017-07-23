using System.Collections.Generic;
using System.Linq;
using Microsoft.CodeAnalysis.CSharp.Syntax;

namespace CSharpDom.CodeAnalysis
{
    internal sealed class InternalClassFieldCollectionWithCodeAnalysis<TClass> :
        ClassFieldCollectionWithCodeAnalysis
        where TClass : class, IHasSyntax<ClassDeclarationSyntax>
    {
        private readonly InternalClassTypeWithCodeAnalysis<TClass> classType;
        private readonly ClassMemberListWrapper<TClass, ClassConstantWithCodeAnalysis, FieldDeclarationSyntax> constants;
        private readonly ClassMemberListWrapper<TClass, ClassFieldWithCodeAnalysis, FieldDeclarationSyntax> fields;

        internal InternalClassFieldCollectionWithCodeAnalysis(InternalClassTypeWithCodeAnalysis<TClass> classType)
        {
            this.classType = classType;
            constants = new ClassMemberListWrapper<TClass, ClassConstantWithCodeAnalysis, FieldDeclarationSyntax>(
                classType.InternalNode,
                () => new ClassConstantWithCodeAnalysis(),
                syntax => syntax.IsConstant());
            fields = new ClassMemberListWrapper<TClass, ClassFieldWithCodeAnalysis, FieldDeclarationSyntax>(
                classType.InternalNode,
                () => new ClassFieldWithCodeAnalysis(),
                syntax => !syntax.IsConstant());
        }
        
        public override ICollection<ClassConstantWithCodeAnalysis> Constants
        {
            get { return constants; }
            set { classType.Members.CombineList(nameof(Constants), value.Select(item => item.Syntax)); }
        }

        public override ICollection<ClassFieldWithCodeAnalysis> Fields
        {
            get { return fields; }
            set { classType.Members.CombineList(nameof(Fields), value.Select(item => item.Syntax)); }
        }
    }
}
