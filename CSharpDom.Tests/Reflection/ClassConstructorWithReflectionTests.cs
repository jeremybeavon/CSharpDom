using CSharpDom.Common;
using CSharpDom.Reflection;
using CSharpDom.Reflection.Internal;
using CSharpDom.Tests.Common;
using CSharpDom.TestTarget.Classes;
using CSharpDom.TestTarget.Classes.Constructors;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Threading.Tasks;

namespace CSharpDom.Tests.Reflection
{
    [TestClass]
    public class ClassConstructorWithReflectionTests : AbstractClassTests<ProjectWithReflection>
    {
        private ISolution<ProjectWithReflection> solution;

        public override ISolution<ProjectWithReflection> Solution
        {
            get { return solution; }
        }

        protected override bool IsConstructorTest
        {
            get { return true; }
        }

        [TestInitialize]
        public void SetUp()
        {
            solution = new AssemblyWithReflection(typeof(PublicClass).Assembly).AsSolution();
        }

        [TestMethod]
        public async Task TestClassWithReflectionWithPublicConstructorAsync()
        {
            await TestClassAsync(typeof(ClassWithPublicConstructor));
        }

        [TestMethod]
        public async Task TestClassWithReflectionWithInternalConstructorAsync()
        {
            await TestClassAsync(typeof(ClassWithInternalConstructor));
        }

        [TestMethod]
        public async Task TestClassWithReflectionWithProtectedInternalConstructorAsync()
        {
            await TestClassAsync(typeof(ClassWithProtectedInternalConstructor));
        }

        [TestMethod]
        public async Task TestClassWithReflectionWithProtectedConstructorAsync()
        {
            await TestClassAsync(typeof(ClassWithProtectedConstructor));
        }

        [TestMethod]
        public async Task TestClassWithReflectionWithPrivateConstructorAsync()
        {
            await TestClassAsync(typeof(ClassWithPrivateConstructor));
        }

        [TestMethod]
        public async Task TestClassWithReflectionWithConstructorWith1ParameterAsync()
        {
            await TestClassAsync(typeof(ClassWithConstructorWith1Parameter));
        }

        [TestMethod]
        public async Task TestClassWithReflectionWithConstructorWith2ParametersAsync()
        {
            await TestClassAsync(typeof(ClassWithConstructorWith2Parameters));
        }

        [TestMethod]
        public async Task TestClassWithReflectionWithConstructorWithParametersWithModifiersAsync()
        {
            await TestClassAsync(typeof(ClassWithConstructorWithParametersWithModifiers));
        }
    }
}
