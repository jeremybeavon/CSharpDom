using CSharpDom.Common;
using CSharpDom.Reflection;
using CSharpDom.Reflection.Internal;
using CSharpDom.Tests.Common;
using CSharpDom.TestTarget.Classes;
using CSharpDom.TestTarget.Classes.Events.EventProperties;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Threading.Tasks;

namespace CSharpDom.Tests.Reflection
{
    [TestClass]
    public class ClassEventPropertyWithReflectionTests : AbstractClassTests<ProjectWithReflection>
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
        public async Task TestClassWithReflectionWithPublicEventPropertyAsync()
        {
            await TestClassAsync(typeof(ClassWithPublicEventProperty));
        }

        [TestMethod]
        public async Task TestClassWithReflectionWithInternalEventPropertyAsync()
        {
            await TestClassAsync(typeof(ClassWithInternalEventProperty));
        }

        [TestMethod]
        public async Task TestClassWithReflectionWithProtectedInternalEventPropertyAsync()
        {
            await TestClassAsync(typeof(ClassWithProtectedInternalEventProperty));
        }

        [TestMethod]
        public async Task TestClassWithReflectionWithProtectedEventPropertyAsync()
        {
            await TestClassAsync(typeof(ClassWithProtectedEventProperty));
        }

        [TestMethod]
        public async Task TestClassWithReflectionWithPrivateEventPropertyAsync()
        {
            await TestClassAsync(typeof(ClassWithPrivateEventProperty));
        }

        [TestMethod]
        public async Task TestClassWithReflectionWithNewEventPropertyAsync()
        {
            await TestClassAsync(typeof(ClassWithNewEventProperty));
        }

        [TestMethod]
        public async Task TestClassWithReflectionWithNewStaticEventPropertyAsync()
        {
            await TestClassAsync(typeof(ClassWithNewStaticEventProperty));
        }

        [TestMethod]
        public async Task TestClassWithReflectionWithNewVirtualEventPropertyAsync()
        {
            await TestClassAsync(typeof(ClassWithNewVirtualEventProperty));
        }

        [TestMethod]
        public async Task TestClassWithReflectionWithOverrideEventPropertyAsync()
        {
            await TestClassAsync(typeof(ClassWithOverrideEventProperty));
        }

        [TestMethod]
        public async Task TestClassWithReflectionWithStaticEventPropertyAsync()
        {
            await TestClassAsync(typeof(ClassWithStaticEventProperty));
        }

        [TestMethod]
        public async Task TestClassWithReflectionWithVirtualEventPropertyAsync()
        {
            await TestClassAsync(typeof(ClassWithVirtualEventProperty));
        }
    }
}
