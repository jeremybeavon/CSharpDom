using CSharpDom.Common;
using CSharpDom.Reflection;
using CSharpDom.Reflection.Internal;
using CSharpDom.Tests.Common;
using CSharpDom.TestTarget.Classes;
using CSharpDom.TestTarget.Classes.Indexers;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Threading.Tasks;

namespace CSharpDom.Tests.Reflection
{
    [TestClass]
    public class ClassIndexerWithReflectionTests : AbstractClassTests<ProjectWithReflection>
    {
        private ISolution<ProjectWithReflection> solution;

        public override ISolution<ProjectWithReflection> Solution
        {
            get { return solution; }
        }
        
        [TestInitialize]
        public void SetUp()
        {
            solution = new AssemblyWithReflection(typeof(PublicClass).Assembly).AsSolution();
        }

        [TestMethod]
        public async Task TestClassWithReflectionWithPublicIndexerAsync()
        {
            await TestClassAsync(typeof(ClassWithPublicIndexer));
        }

        [TestMethod]
        public async Task TestClassWithReflectionWithInternalIndexerAsync()
        {
            await TestClassAsync(typeof(ClassWithInternalIndexer));
        }

        [TestMethod]
        public async Task TestClassWithReflectionWithProtectedInternalIndexerAsync()
        {
            await TestClassAsync(typeof(ClassWithProtectedInternalIndexer));
        }

        [TestMethod]
        public async Task TestClassWithReflectionWithProtectedIndexerAsync()
        {
            await TestClassAsync(typeof(ClassWithProtectedIndexer));
        }

        [TestMethod]
        public async Task TestClassWithReflectionWithPrivateIndexerAsync()
        {
            await TestClassAsync(typeof(ClassWithPrivateIndexer));
        }

        [TestMethod]
        public async Task TestClassWithReflectionWithNewIndexerAsync()
        {
            await TestClassAsync(typeof(ClassWithNewIndexer));
        }
        
        [TestMethod]
        public async Task TestClassWithReflectionWithNewVirtualIndexerAsync()
        {
            await TestClassAsync(typeof(ClassWithNewVirtualIndexer));
        }

        [TestMethod]
        public async Task TestClassWithReflectionWithOverrideIndexerAsync()
        {
            await TestClassAsync(typeof(ClassWithOverrideIndexer));
        }
        
        [TestMethod]
        public async Task TestClassWithReflectionWithVirtualIndexerAsync()
        {
            await TestClassAsync(typeof(ClassWithVirtualIndexer));
        }
    }
}
