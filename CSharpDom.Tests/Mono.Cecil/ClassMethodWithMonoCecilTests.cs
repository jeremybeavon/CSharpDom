using CSharpDom.Common;
using CSharpDom.Mono.Cecil;
using CSharpDom.Mono.Cecil.Internal;
using CSharpDom.Tests.Common;
using CSharpDom.TestTarget.Classes;
using CSharpDom.TestTarget.Classes.Methods;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Mono.Cecil;
using System.Threading.Tasks;

namespace CSharpDom.Tests.Mono.Cecil
{
    [TestClass]
    public class ClassMethodWithMonoCecilTests : AbstractSolutionTests<ProjectWithMonoCecil>
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
        public async Task TestClassWithMonoCecilWithPublicMethodAsync()
        {
            await TestClassAsync(typeof(ClassWithPublicMethod));
        }

        [TestMethod]
        public async Task TestClassWithMonoCecilWithInternalMethodAsync()
        {
            await TestClassAsync(typeof(ClassWithInternalMethod));
        }

        [TestMethod]
        public async Task TestClassWithMonoCecilWithProtectedInternalMethodAsync()
        {
            await TestClassAsync(typeof(ClassWithProtectedInternalMethod));
        }

        [TestMethod]
        public async Task TestClassWithMonoCecilWithProtectedMethodAsync()
        {
            await TestClassAsync(typeof(ClassWithProtectedMethod));
        }

        [TestMethod]
        public async Task TestClassWithMonoCecilWithPrivateMethodAsync()
        {
            await TestClassAsync(typeof(ClassWithPrivateMethod));
        }

        [TestMethod]
        public async Task TestClassWithMonoCecilWithNewMethodAsync()
        {
            await TestClassAsync(typeof(ClassWithNewMethod));
        }

        [TestMethod]
        public async Task TestClassWithMonoCecilWithNewStaticMethodAsync()
        {
            await TestClassAsync(typeof(ClassWithNewStaticMethod));
        }

        [TestMethod]
        public async Task TestClassWithMonoCecilWithNewVirtualMethodAsync()
        {
            await TestClassAsync(typeof(ClassWithNewVirtualMethod));
        }

        [TestMethod]
        public async Task TestClassWithMonoCecilWithOverrideMethodAsync()
        {
            await TestClassAsync(typeof(ClassWithOverrideMethod));
        }

        [TestMethod]
        public async Task TestClassWithMonoCecilWithStaticMethodAsync()
        {
            await TestClassAsync(typeof(ClassWithStaticMethod));
        }

        [TestMethod]
        public async Task TestClassWithMonoCecilWithVirtualMethodAsync()
        {
            await TestClassAsync(typeof(ClassWithVirtualMethod));
        }
    }
}
