using System;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpDom.CodeGeneration.Tree
{
    public sealed class ClassBody : CodeGenerationNode
    {
        public ClassBody()
        {
            Fields = new CodeGenerationCollection<ClassFieldDeclaration>();
            Events = new CodeGenerationCollection<ClassEvent>();
            Properties = new CodeGenerationCollection<ClassProperty>();
            Indexers = new CodeGenerationCollection<ClassIndexer>();
            Methods = new CodeGenerationCollection<ClassMethod>();
            UnaryOperators = new CodeGenerationCollection<UnaryOperator>();
            BinaryOperators = new CodeGenerationCollection<BinaryOperator>();
            ConversionOperators = new CodeGenerationCollection<ConversionOperator>();
            NestedClasses = new CodeGenerationCollection<ClassNestedClass>();
            NestedDelegates = new CodeGenerationCollection<ClassNestedDelegate>();
            NestedEnums = new CodeGenerationCollection<ClassNestedEnum>();
            NestedInterfaces = new CodeGenerationCollection<ClassNestedInterface>();
            NestedStructs = new CodeGenerationCollection<ClassNestedStruct>();
        }

        public CodeGenerationCollection<ClassFieldDeclaration> Fields { get; set; }

        public CodeGenerationCollection<ClassEvent> Events { get; set; }

        public CodeGenerationCollection<ClassProperty> Properties { get; set; }

        public CodeGenerationCollection<ClassIndexer> Indexers { get; set; }

        public CodeGenerationCollection<ClassMethod> Methods { get; set; }

        public CodeGenerationCollection<UnaryOperator> UnaryOperators { get; set; }

        public CodeGenerationCollection<BinaryOperator> BinaryOperators { get; set; }

        public CodeGenerationCollection<ConversionOperator> ConversionOperators { get; set; }

        public CodeGenerationCollection<ClassNestedClass> NestedClasses { get; set; }

        public CodeGenerationCollection<ClassNestedDelegate> NestedDelegates { get; set; }

        public CodeGenerationCollection<ClassNestedEnum> NestedEnums { get; set; }

        public CodeGenerationCollection<ClassNestedInterface> NestedInterfaces { get; set; }

        public CodeGenerationCollection<ClassNestedStruct> NestedStructs { get; set; }

        public override void Accept(CodeGenerationVisitor visitor)
        {
            if (visitor != null)
            {
                visitor.Visit(this);
            }
        }

        public override void AcceptChildren(CodeGenerationVisitor visitor)
        {
            Fields.AcceptIfNotNull(visitor);
            Events.AcceptIfNotNull(visitor);
            Properties.AcceptIfNotNull(visitor);
            Indexers.AcceptIfNotNull(visitor);
            Methods.AcceptIfNotNull(visitor);
            UnaryOperators.AcceptIfNotNull(visitor);
            BinaryOperators.AcceptIfNotNull(visitor);
            ConversionOperators.AcceptIfNotNull(visitor);
            NestedClasses.AcceptIfNotNull(visitor);
            NestedDelegates.AcceptIfNotNull(visitor);
            NestedEnums.AcceptIfNotNull(visitor);
            NestedInterfaces.AcceptIfNotNull(visitor);
            NestedStructs.AcceptIfNotNull(visitor);
        }
    }
}
