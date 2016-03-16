using CSharpDom.Common;
using CSharpDom.Mono.Cecil;
using CSharpDom.Mono.Cecil.Internal;
using CSharpDom.Tests.Common;
using CSharpDom.TestTarget.Classes;
using CSharpDom.TestTarget.Classes.Events.EventProperties;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Mono.Cecil;
using System.Threading.Tasks;

namespace CSharpDom.Tests.Mono.Cecil
{
    [TestClass]
    public class ClassEventPropertyWithMonoCecilTests : AbstractSolutionTests<ProjectWithMonoCecil>
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
        public async Task TestClassWithMonoCecilWithPublicEventPropertyAsync()
        {
            await TestClassAsync(typeof(ClassWithPublicEventProperty));
        }

        [TestMethod]
        public async Task TestClassWithMonoCecilWithInternalEventPropertyAsync()
        {
            await TestClassAsync(typeof(ClassWithInternalEventProperty));
        }

        [TestMethod]
        public async Task TestClassWithMonoCecilWithProtectedInternalEventPropertyAsync()
        {
            await TestClassAsync(typeof(ClassWithProtectedInternalEventProperty));
        }

        [TestMethod]
        public async Task TestClassWithMonoCecilWithProtectedEventPropertyAsync()
        {
            await TestClassAsync(typeof(ClassWithProtectedEventProperty));
        }

        [TestMethod]
        public async Task TestClassWithMonoCecilWithPrivateEventPropertyAsync()
        {
            await TestClassAsync(typeof(ClassWithPrivateEventProperty));
        }

        [TestMethod]
        public async Task TestClassWithMonoCecilWithNewEventPropertyAsync()
        {
            await TestClassAsync(typeof(ClassWithNewEventProperty));
        }

        [TestMethod]
        public async Task TestClassWithMonoCecilWithNewStaticEventPropertyAsync()
        {
            await TestClassAsync(typeof(ClassWithNewStaticEventProperty));
        }

        [TestMethod]
        public async Task TestClassWithMonoCecilWithNewVirtualEventPropertyAsync()
        {
            await TestClassAsync(typeof(ClassWithNewVirtualEventProperty));
        }

        [TestMethod]
        public async Task TestClassWithMonoCecilWithOverrideEventPropertyAsync()
        {
            await TestClassAsync(typeof(ClassWithOverrideEventProperty));
        }

        [TestMethod]
        public async Task TestClassWithMonoCecilWithStaticEventPropertyAsync()
        {
            await TestClassAsync(typeof(ClassWithStaticEventProperty));
        }

        [TestMethod]
        public async Task TestClassWithMonoCecilWithVirtualEventPropertyAsync()
        {
            await TestClassAsync(typeof(ClassWithVirtualEventProperty));
        }
    }
}
