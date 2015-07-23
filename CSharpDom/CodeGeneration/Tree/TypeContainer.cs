using System;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpDom.CodeGeneration.Tree
{
    public abstract class TypeContainer : CodeGenerationNode
    {
        protected TypeContainer()
        {
            Classes = new CodeGenerationCollection<Class>();
            Delegates = new CodeGenerationCollection<Delegate>();
            Enums = new CodeGenerationCollection<Enum>();
            Interfaces = new CodeGenerationCollection<Interface>();
            Structs = new CodeGenerationCollection<Struct>();
        }

        public CodeGenerationCollection<Class> Classes { get; set; }

        public CodeGenerationCollection<Delegate> Delegates { get; set; }

        public CodeGenerationCollection<Enum> Enums { get; set; }

        public CodeGenerationCollection<Interface> Interfaces { get; set; }

        public CodeGenerationCollection<Struct> Structs { get; set; }
    }
}
