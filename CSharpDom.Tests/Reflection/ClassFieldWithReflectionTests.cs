using CSharpDom.Common;
using CSharpDom.Reflection;
using CSharpDom.Reflection.Internal;
using CSharpDom.Tests.Common;
using CSharpDom.TestTarget.Classes;
using CSharpDom.TestTarget.Classes.Fields;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Threading.Tasks;

namespace CSharpDom.Tests.Reflection
{
    [TestClass]
    public class ClassFieldWithReflectionTests : AbstractSolutionTests<ProjectWithReflection>
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
        public async Task TestClassWithReflectionWithConstField()
        {
            await TestClassAsync(typeof(ClassWithConstField));
        }

        [TestMethod]
        public async Task TestClassWithReflectionWithInternalField()
        {
            await TestClassAsync(typeof(ClassWithInternalField));
        }

        [TestMethod]
        public async Task TestClassWithReflectionWithNewField()
        {
            await TestClassAsync(typeof(ClassWithNewField));
        }

        [TestMethod]
        public async Task TestClassWithReflectionWithNewStaticField()
        {
            await TestClassAsync(typeof(ClassWithNewStaticField));
        }

        [TestMethod]
        public async Task TestClassWithReflectionWithNewStaticReadOnlyField()
        {
            await TestClassAsync(typeof(ClassWithNewStaticReadOnlyField));
        }

        [TestMethod]
        public async Task TestClassWithReflectionWithNewStaticVolatileField()
        {
            await TestClassAsync(typeof(ClassWithNewStaticVolatileField));
        }

        [TestMethod]
        public async Task TestClassWithReflectionWithNewVolatileField()
        {
            await TestClassAsync(typeof(ClassWithNewVolatileField));
        }

        [TestMethod]
        public async Task TestClassWithReflectionWithPrivateField()
        {
            await TestClassAsync(typeof(ClassWithPrivateField));
        }

        [TestMethod]
        public async Task TestClassWithReflectionWithProtectedField()
        {
            await TestClassAsync(typeof(ClassWithProtectedField));
        }

        [TestMethod]
        public async Task TestClassWithReflectionWithProtectedInternalField()
        {
            await TestClassAsync(typeof(ClassWithProtectedInternalField));
        }

        [TestMethod]
        public async Task TestClassWithReflectionWithPublicField()
        {
            await TestClassAsync(typeof(ClassWithPublicField));
        }

        [TestMethod]
        public async Task TestClassWithReflectionWithReadOnlyField()
        {
            await TestClassAsync(typeof(ClassWithReadOnlyField));
        }

        [TestMethod]
        public async Task TestClassWithReflectionWithStaticField()
        {
            await TestClassAsync(typeof(ClassWithStaticField));
        }

        [TestMethod]
        public async Task TestClassWithReflectionWithStaticReadOnlyField()
        {
            await TestClassAsync(typeof(ClassWithStaticReadOnlyField));
        }

        [TestMethod]
        public async Task TestClassWithReflectionWithStaticVolatileField()
        {
            await TestClassAsync(typeof(ClassWithStaticVolatileField));
        }

        [TestMethod]
        public async Task TestClassWithReflectionWithVolatileField()
        {
            await TestClassAsync(typeof(ClassWithVolatileField));
        }
    }
}
