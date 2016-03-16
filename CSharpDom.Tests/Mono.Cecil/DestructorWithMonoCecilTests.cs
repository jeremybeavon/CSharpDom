using CSharpDom.Common;
using CSharpDom.Mono.Cecil;
using CSharpDom.Mono.Cecil.Internal;
using CSharpDom.Tests.Common;
using CSharpDom.TestTarget.Classes;
using CSharpDom.TestTarget.Classes.Destructors;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Mono.Cecil;
using System.Threading.Tasks;

namespace CSharpDom.Tests.Mono.Cecil
{
    [TestClass]
    public class DestructorWithMonoCecilTests : AbstractSolutionTests<ProjectWithMonoCecil>
    {
        private ISolution<ProjectWithMonoCecil> solution;

        public override ISolution<ProjectWithMonoCecil> Solution
        {
            get { return solution; }
        }

        [TestInitialize]
        public void SetUp()
        {
            solution = new AssemblyWithMonoCecil(AssemblyDefinition.ReadAssembly(typeof(PublicClass).Assembly.Location)).AsSolution();
        }

        [TestMethod]
        public async Task TestClassWithMonoCecilWithDestructorAsync()
        {
            await TestClassAsync(typeof(ClassWithDestructor));
        }
    }
}
