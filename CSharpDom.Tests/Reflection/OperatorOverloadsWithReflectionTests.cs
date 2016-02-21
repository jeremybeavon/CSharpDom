using CSharpDom.Common;
using CSharpDom.Reflection;
using CSharpDom.Reflection.Internal;
using CSharpDom.Tests.Common;
using CSharpDom.TestTarget.Classes;
using CSharpDom.TestTarget.Classes.OperatorOverloads;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Threading.Tasks;

namespace CSharpDom.Tests.Reflection
{
    [TestClass]
    public class OperatorOverloadWithReflectionTests : AbstractSolutionTests<ProjectWithReflection>
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
        public async Task TestClassWithReflectionWithAndOperatorOverloadAsync()
        {
            await TestClassAsync(typeof(ClassWithAndOperatorOverload));
        }

        [TestMethod]
        public async Task TestClassWithReflectionWithBitwiseNotOperatorOverloadAsync()
        {
            await TestClassAsync(typeof(ClassWithBitwiseNotOperatorOverload));
        }

        [TestMethod]
        public async Task TestClassWithReflectionWithDecrementOperatorOverloadAsync()
        {
            await TestClassAsync(typeof(ClassWithDecrementOperatorOverload));
        }

        [TestMethod]
        public async Task TestClassWithReflectionWithDivideOperatorOverloadAsync()
        {
            await TestClassAsync(typeof(ClassWithDivideOperatorOverload));
        }

        [TestMethod]
        public async Task TestClassWithReflectionWithEqualAndNotEqualOperatorOverloadsAsync()
        {
            await TestClassAsync(typeof(ClassWithEqualAndNotEqualOperatorOverloads));
        }

        [TestMethod]
        public async Task TestClassWithReflectionWithExclusiveOrOperatorOverloadAsync()
        {
            await TestClassAsync(typeof(ClassWithExclusiveOrOperatorOverload));
        }

        [TestMethod]
        public async Task TestClassWithReflectionWithIncrementOperatorOverloadAsync()
        {
            await TestClassAsync(typeof(ClassWithIncrementOperatorOverload));
        }

        [TestMethod]
        public async Task TestClassWithReflectionWithLeftShiftOperatorOverloadAsync()
        {
            await TestClassAsync(typeof(ClassWithLeftShiftOperatorOverload));
        }

        [TestMethod]
        public async Task TestClassWithReflectionWithLessThanAndGreaterThanOperatorOverloadsAsync()
        {
            await TestClassAsync(typeof(ClassWithLessThanAndGreaterThanOperatorOverloads));
        }

        [TestMethod]
        public async Task TestClassWithReflectionWithLessThanOrEqualAndGreaterThanOrEqualOperatorOverloadsAsync()
        {
            await TestClassAsync(typeof(ClassWithLessThanOrEqualAndGreaterThanOrEqualOperatorOverloads));
        }

        [TestMethod]
        public async Task TestClassWithReflectionWithLogicalNotOperatorOverloadAsync()
        {
            await TestClassAsync(typeof(ClassWithLogicalNotOperatorOverload));
        }

        [TestMethod]
        public async Task TestClassWithReflectionWithMinusOperatorOverloadAsync()
        {
            await TestClassAsync(typeof(ClassWithMinusOperatorOverload));
        }

        [TestMethod]
        public async Task TestClassWithReflectionWithModuloOperatorOverloadAsync()
        {
            await TestClassAsync(typeof(ClassWithModuloOperatorOverload));
        }

        [TestMethod]
        public async Task TestClassWithReflectionWithMultiplyOperatorOverloadAsync()
        {
            await TestClassAsync(typeof(ClassWithMultiplyOperatorOverload));
        }

        [TestMethod]
        public async Task TestClassWithReflectionWithOrOperatorOverloadAsync()
        {
            await TestClassAsync(typeof(ClassWithOrOperatorOverload));
        }

        [TestMethod]
        public async Task TestClassWithReflectionWithPlusOperatorOverloadAsync()
        {
            await TestClassAsync(typeof(ClassWithPlusOperatorOverload));
        }

        [TestMethod]
        public async Task TestClassWithReflectionWithRightShiftOperatorOverloadAsync()
        {
            await TestClassAsync(typeof(ClassWithRightShiftOperatorOverload));
        }

        [TestMethod]
        public async Task TestClassWithReflectionWithTrueAndFalseOperatorOverloadsAsync()
        {
            await TestClassAsync(typeof(ClassWithTrueAndFalseOperatorOverloads));
        }

        [TestMethod]
        public async Task TestClassWithReflectionWithUnaryMinusOperatorOverloadAsync()
        {
            await TestClassAsync(typeof(ClassWithUnaryMinusOperatorOverload));
        }

        [TestMethod]
        public async Task TestClassWithReflectionWithUnaryPlusOperatorOverloadAsync()
        {
            await TestClassAsync(typeof(ClassWithUnaryPlusOperatorOverload));
        }
    }
}
