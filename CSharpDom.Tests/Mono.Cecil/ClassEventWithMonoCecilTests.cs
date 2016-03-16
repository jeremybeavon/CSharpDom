using CSharpDom.Common;
using CSharpDom.Mono.Cecil;
using CSharpDom.Mono.Cecil.Internal;
using CSharpDom.Tests.Common;
using CSharpDom.TestTarget.Classes;
using CSharpDom.TestTarget.Classes.Events;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Mono.Cecil;
using System.Threading.Tasks;

namespace CSharpDom.Tests.Mono.Cecil
{
    [TestClass]
    public class ClassEventWithMonoCecilTests : AbstractSolutionTests<ProjectWithMonoCecil>
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
        public async Task TestClassWithMonoCecilWithPublicEventAsync()
        {
            await TestClassAsync(typeof(ClassWithPublicEvent));
        }

        [TestMethod]
        public async Task TestClassWithMonoCecilWithInternalEventAsync()
        {
            await TestClassAsync(typeof(ClassWithInternalEvent));
        }

        [TestMethod]
        public async Task TestClassWithMonoCecilWithProtectedInternalEventAsync()
        {
            await TestClassAsync(typeof(ClassWithProtectedInternalEvent));
        }

        [TestMethod]
        public async Task TestClassWithMonoCecilWithProtectedEventAsync()
        {
            await TestClassAsync(typeof(ClassWithProtectedEvent));
        }

        [TestMethod]
        public async Task TestClassWithMonoCecilWithPrivateEventAsync()
        {
            await TestClassAsync(typeof(ClassWithPrivateEvent));
        }

        [TestMethod]
        public async Task TestClassWithMonoCecilWithNewEventAsync()
        {
            await TestClassAsync(typeof(ClassWithNewEvent));
        }

        [TestMethod]
        public async Task TestClassWithMonoCecilWithNewStaticEventAsync()
        {
            await TestClassAsync(typeof(ClassWithNewStaticEvent));
        }

        [TestMethod]
        public async Task TestClassWithMonoCecilWithNewVirtualEventAsync()
        {
            await TestClassAsync(typeof(ClassWithNewVirtualEvent));
        }

        [TestMethod]
        public async Task TestClassWithMonoCecilWithOverrideEventAsync()
        {
            await TestClassAsync(typeof(ClassWithOverrideEvent));
        }

        [TestMethod]
        public async Task TestClassWithMonoCecilWithStaticEventAsync()
        {
            await TestClassAsync(typeof(ClassWithStaticEvent));
        }

        [TestMethod]
        public async Task TestClassWithMonoCecilWithVirtualEventAsync()
        {
            await TestClassAsync(typeof(ClassWithVirtualEvent));
        }
    }
}
