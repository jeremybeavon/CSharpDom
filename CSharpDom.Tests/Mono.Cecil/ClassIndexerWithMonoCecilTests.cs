using CSharpDom.Common;
using CSharpDom.Mono.Cecil;
using CSharpDom.Mono.Cecil.Internal;
using CSharpDom.Tests.Common;
using CSharpDom.TestTarget.Classes;
using CSharpDom.TestTarget.Classes.Indexers;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Mono.Cecil;
using System.Threading.Tasks;

namespace CSharpDom.Tests.Mono.Cecil
{
    [TestClass]
    public class ClassIndexerWithMonoCecilTests : AbstractSolutionTests<ProjectWithMonoCecil>
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
        public async Task TestClassWithMonoCecilWithPublicIndexerAsync()
        {
            await TestClassAsync(typeof(ClassWithPublicIndexer));
        }

        [TestMethod]
        public async Task TestClassWithMonoCecilWithInternalIndexerAsync()
        {
            await TestClassAsync(typeof(ClassWithInternalIndexer));
        }

        [TestMethod]
        public async Task TestClassWithMonoCecilWithProtectedInternalIndexerAsync()
        {
            await TestClassAsync(typeof(ClassWithProtectedInternalIndexer));
        }

        [TestMethod]
        public async Task TestClassWithMonoCecilWithProtectedIndexerAsync()
        {
            await TestClassAsync(typeof(ClassWithProtectedIndexer));
        }

        [TestMethod]
        public async Task TestClassWithMonoCecilWithPrivateIndexerAsync()
        {
            await TestClassAsync(typeof(ClassWithPrivateIndexer));
        }

        [TestMethod]
        public async Task TestClassWithMonoCecilWithNewIndexerAsync()
        {
            await TestClassAsync(typeof(ClassWithNewIndexer));
        }
        
        [TestMethod]
        public async Task TestClassWithMonoCecilWithNewVirtualIndexerAsync()
        {
            await TestClassAsync(typeof(ClassWithNewVirtualIndexer));
        }

        [TestMethod]
        public async Task TestClassWithMonoCecilWithOverrideIndexerAsync()
        {
            await TestClassAsync(typeof(ClassWithOverrideIndexer));
        }
        
        [TestMethod]
        public async Task TestClassWithMonoCecilWithVirtualIndexerAsync()
        {
            await TestClassAsync(typeof(ClassWithVirtualIndexer));
        }
    }
}
