using CSharpDom.Common;
using CSharpDom.Mono.Cecil;
using CSharpDom.Mono.Cecil.Internal;
using CSharpDom.Tests.Common;
using CSharpDom.TestTarget.Classes;
using CSharpDom.TestTarget.Classes.Properties;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Mono.Cecil;
using System.Threading.Tasks;

namespace CSharpDom.Tests.Mono.Cecil
{
    [TestClass]
    public class ClassPropertyWithMonoCecilTests : AbstractSolutionTests<ProjectWithMonoCecil>
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
        public async Task TestClassWithMonoCecilWithPublicPropertyAsync()
        {
            await TestClassAsync(typeof(ClassWithPublicProperty));
        }

        [TestMethod]
        public async Task TestClassWithMonoCecilWithInternalPropertyAsync()
        {
            await TestClassAsync(typeof(ClassWithInternalProperty));
        }

        [TestMethod]
        public async Task TestClassWithMonoCecilWithProtectedInternalPropertyAsync()
        {
            await TestClassAsync(typeof(ClassWithProtectedInternalProperty));
        }

        [TestMethod]
        public async Task TestClassWithMonoCecilWithProtectedPropertyAsync()
        {
            await TestClassAsync(typeof(ClassWithProtectedProperty));
        }

        [TestMethod]
        public async Task TestClassWithMonoCecilWithPrivatePropertyAsync()
        {
            await TestClassAsync(typeof(ClassWithPrivateProperty));
        }

        [TestMethod]
        public async Task TestClassWithMonoCecilWithNewPropertyAsync()
        {
            await TestClassAsync(typeof(ClassWithNewProperty));
        }

        [TestMethod]
        public async Task TestClassWithMonoCecilWithNewStaticPropertyAsync()
        {
            await TestClassAsync(typeof(ClassWithNewStaticProperty));
        }

        [TestMethod]
        public async Task TestClassWithMonoCecilWithNewVirtualPropertyAsync()
        {
            await TestClassAsync(typeof(ClassWithNewVirtualProperty));
        }

        [TestMethod]
        public async Task TestClassWithMonoCecilWithOverridePropertyAsync()
        {
            await TestClassAsync(typeof(ClassWithOverrideProperty));
        }

        [TestMethod]
        public async Task TestClassWithMonoCecilWithStaticPropertyAsync()
        {
            await TestClassAsync(typeof(ClassWithStaticProperty));
        }

        [TestMethod]
        public async Task TestClassWithMonoCecilWithVirtualPropertyAsync()
        {
            await TestClassAsync(typeof(ClassWithVirtualProperty));
        }
    }
}
