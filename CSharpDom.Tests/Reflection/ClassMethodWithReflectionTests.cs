using CSharpDom.Common;
using CSharpDom.Reflection;
using CSharpDom.Reflection.Internal;
using CSharpDom.Tests.Common;
using CSharpDom.TestTarget.Classes;
using CSharpDom.TestTarget.Classes.Methods;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Threading.Tasks;

namespace CSharpDom.Tests.Reflection
{
    [TestClass]
    public sealed partial class ClassMethodWithReflectionTests : AbstractSolutionTests<ProjectWithReflection>
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
        public async Task TestClassWithReflectionWithPublicMethodAsync()
        {
            await TestClassAsync(typeof(ClassWithPublicMethod));
        }

        [TestMethod]
        public async Task TestClassWithReflectionWithInternalMethodAsync()
        {
            await TestClassAsync(typeof(ClassWithInternalMethod));
        }

        [TestMethod]
        public async Task TestClassWithReflectionWithProtectedInternalMethodAsync()
        {
            await TestClassAsync(typeof(ClassWithProtectedInternalMethod));
        }

        [TestMethod]
        public async Task TestClassWithReflectionWithProtectedMethodAsync()
        {
            await TestClassAsync(typeof(ClassWithProtectedMethod));
        }

        [TestMethod]
        public async Task TestClassWithReflectionWithPrivateMethodAsync()
        {
            await TestClassAsync(typeof(ClassWithPrivateMethod));
        }

        [TestMethod]
        public async Task TestClassWithReflectionWithNewMethodAsync()
        {
            await TestClassAsync(typeof(ClassWithNewMethod));
        }

        [TestMethod]
        public async Task TestClassWithReflectionWithNewStaticMethodAsync()
        {
            await TestClassAsync(typeof(ClassWithNewStaticMethod));
        }

        [TestMethod]
        public async Task TestClassWithReflectionWithNewVirtualMethodAsync()
        {
            await TestClassAsync(typeof(ClassWithNewVirtualMethod));
        }

        [TestMethod]
        public async Task TestClassWithReflectionWithOverrideMethodAsync()
        {
            await TestClassAsync(typeof(ClassWithOverrideMethod));
        }

        [TestMethod]
        public async Task TestClassWithReflectionWithStaticMethodAsync()
        {
            await TestClassAsync(typeof(ClassWithStaticMethod));
        }

        [TestMethod]
        public async Task TestClassWithReflectionWithVirtualMethodAsync()
        {
            await TestClassAsync(typeof(ClassWithVirtualMethod));
        }
    }
}
