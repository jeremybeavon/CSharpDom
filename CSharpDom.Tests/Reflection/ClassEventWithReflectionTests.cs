using CSharpDom.Common;
using CSharpDom.Reflection;
using CSharpDom.Reflection.Internal;
using CSharpDom.Tests.Common;
using CSharpDom.TestTarget.Classes;
using CSharpDom.TestTarget.Classes.Events;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Threading.Tasks;

namespace CSharpDom.Tests.Reflection
{
    [TestClass]
    public class ClassEventWithReflectionTests : AbstractClassTests<ProjectWithReflection>
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
        public async Task TestClassWithReflectionWithPublicEventAsync()
        {
            await TestClassAsync(typeof(ClassWithPublicEvent));
        }

        [TestMethod]
        public async Task TestClassWithReflectionWithInternalEventAsync()
        {
            await TestClassAsync(typeof(ClassWithInternalEvent));
        }

        [TestMethod]
        public async Task TestClassWithReflectionWithProtectedInternalEventAsync()
        {
            await TestClassAsync(typeof(ClassWithProtectedInternalEvent));
        }

        [TestMethod]
        public async Task TestClassWithReflectionWithProtectedEventAsync()
        {
            await TestClassAsync(typeof(ClassWithProtectedEvent));
        }

        [TestMethod]
        public async Task TestClassWithReflectionWithPrivateEventAsync()
        {
            await TestClassAsync(typeof(ClassWithPrivateEvent));
        }

        [TestMethod]
        public async Task TestClassWithReflectionWithNewEventAsync()
        {
            await TestClassAsync(typeof(ClassWithNewEvent));
        }

        [TestMethod]
        public async Task TestClassWithReflectionWithNewStaticEventAsync()
        {
            await TestClassAsync(typeof(ClassWithNewStaticEvent));
        }

        [TestMethod]
        public async Task TestClassWithReflectionWithNewVirtualEventAsync()
        {
            await TestClassAsync(typeof(ClassWithNewVirtualEvent));
        }

        [TestMethod]
        public async Task TestClassWithReflectionWithOverrideEventAsync()
        {
            await TestClassAsync(typeof(ClassWithOverrideEvent));
        }

        [TestMethod]
        public async Task TestClassWithReflectionWithStaticEventAsync()
        {
            await TestClassAsync(typeof(ClassWithStaticEvent));
        }

        [TestMethod]
        public async Task TestClassWithReflectionWithVirtualEventAsync()
        {
            await TestClassAsync(typeof(ClassWithVirtualEvent));
        }
    }
}
