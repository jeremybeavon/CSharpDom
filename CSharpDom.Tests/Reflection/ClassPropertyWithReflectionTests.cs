using CSharpDom.Common;
using CSharpDom.Reflection;
using CSharpDom.Reflection.Internal;
using CSharpDom.Tests.Common;
using CSharpDom.TestTarget.Classes;
using CSharpDom.TestTarget.Classes.Properties;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Threading.Tasks;

namespace CSharpDom.Tests.Reflection
{
    [TestClass]
    public class ClassPropertyWithReflectionTests : AbstractClassTests<ProjectWithReflection>
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
        public async Task TestClassWithReflectionWithPublicPropertyAsync()
        {
            await TestClassAsync(typeof(ClassWithPublicProperty));
        }

        [TestMethod]
        public async Task TestClassWithReflectionWithInternalPropertyAsync()
        {
            await TestClassAsync(typeof(ClassWithInternalProperty));
        }

        [TestMethod]
        public async Task TestClassWithReflectionWithProtectedInternalPropertyAsync()
        {
            await TestClassAsync(typeof(ClassWithProtectedInternalProperty));
        }

        [TestMethod]
        public async Task TestClassWithReflectionWithProtectedPropertyAsync()
        {
            await TestClassAsync(typeof(ClassWithProtectedProperty));
        }

        [TestMethod]
        public async Task TestClassWithReflectionWithPrivatePropertyAsync()
        {
            await TestClassAsync(typeof(ClassWithPrivateProperty));
        }

        [TestMethod]
        public async Task TestClassWithReflectionWithNewPropertyAsync()
        {
            await TestClassAsync(typeof(ClassWithNewProperty));
        }

        [TestMethod]
        public async Task TestClassWithReflectionWithNewStaticPropertyAsync()
        {
            await TestClassAsync(typeof(ClassWithNewStaticProperty));
        }

        [TestMethod]
        public async Task TestClassWithReflectionWithNewVirtualPropertyAsync()
        {
            await TestClassAsync(typeof(ClassWithNewVirtualProperty));
        }

        [TestMethod]
        public async Task TestClassWithReflectionWithOverridePropertyAsync()
        {
            await TestClassAsync(typeof(ClassWithOverrideProperty));
        }

        [TestMethod]
        public async Task TestClassWithReflectionWithStaticPropertyAsync()
        {
            await TestClassAsync(typeof(ClassWithStaticProperty));
        }

        [TestMethod]
        public async Task TestClassWithReflectionWithVirtualPropertyAsync()
        {
            await TestClassAsync(typeof(ClassWithVirtualProperty));
        }
    }
}
