using CSharpDom.Common;
using CSharpDom.Mono.Cecil;
using CSharpDom.Mono.Cecil.Internal;
using CSharpDom.Tests.Common;
using CSharpDom.TestTarget.Classes;
using CSharpDom.TestTarget.Classes.OperatorOverloads;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Mono.Cecil;
using System.Threading.Tasks;

namespace CSharpDom.Tests.Mono.Cecil
{
    [TestClass]
    public class OperatorOverloadWithMonoCecilTests : AbstractSolutionTests<ProjectWithMonoCecil>
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
        public async Task TestClassWithMonoCecilWithAndOperatorOverloadAsync()
        {
            await TestClassAsync(typeof(ClassWithAndOperatorOverload));
        }

        [TestMethod]
        public async Task TestClassWithMonoCecilWithBitwiseNotOperatorOverloadAsync()
        {
            await TestClassAsync(typeof(ClassWithBitwiseNotOperatorOverload));
        }

        [TestMethod]
        public async Task TestClassWithMonoCecilWithDecrementOperatorOverloadAsync()
        {
            await TestClassAsync(typeof(ClassWithDecrementOperatorOverload));
        }

        [TestMethod]
        public async Task TestClassWithMonoCecilWithDivideOperatorOverloadAsync()
        {
            await TestClassAsync(typeof(ClassWithDivideOperatorOverload));
        }

        [TestMethod]
        public async Task TestClassWithMonoCecilWithEqualAndNotEqualOperatorOverloadsAsync()
        {
            await TestClassAsync(typeof(ClassWithEqualAndNotEqualOperatorOverloads));
        }

        [TestMethod]
        public async Task TestClassWithMonoCecilWithExclusiveOrOperatorOverloadAsync()
        {
            await TestClassAsync(typeof(ClassWithExclusiveOrOperatorOverload));
        }

        [TestMethod]
        public async Task TestClassWithMonoCecilWithIncrementOperatorOverloadAsync()
        {
            await TestClassAsync(typeof(ClassWithIncrementOperatorOverload));
        }

        [TestMethod]
        public async Task TestClassWithMonoCecilWithLeftShiftOperatorOverloadAsync()
        {
            await TestClassAsync(typeof(ClassWithLeftShiftOperatorOverload));
        }

        [TestMethod]
        public async Task TestClassWithMonoCecilWithLessThanAndGreaterThanOperatorOverloadsAsync()
        {
            await TestClassAsync(typeof(ClassWithLessThanAndGreaterThanOperatorOverloads));
        }

        [TestMethod]
        public async Task TestClassWithMonoCecilWithLessThanOrEqualAndGreaterThanOrEqualOperatorOverloadsAsync()
        {
            await TestClassAsync(typeof(ClassWithLessThanOrEqualAndGreaterThanOrEqualOperatorOverloads));
        }

        [TestMethod]
        public async Task TestClassWithMonoCecilWithLogicalNotOperatorOverloadAsync()
        {
            await TestClassAsync(typeof(ClassWithLogicalNotOperatorOverload));
        }

        [TestMethod]
        public async Task TestClassWithMonoCecilWithMinusOperatorOverloadAsync()
        {
            await TestClassAsync(typeof(ClassWithMinusOperatorOverload));
        }

        [TestMethod]
        public async Task TestClassWithMonoCecilWithModuloOperatorOverloadAsync()
        {
            await TestClassAsync(typeof(ClassWithModuloOperatorOverload));
        }

        [TestMethod]
        public async Task TestClassWithMonoCecilWithMultiplyOperatorOverloadAsync()
        {
            await TestClassAsync(typeof(ClassWithMultiplyOperatorOverload));
        }

        [TestMethod]
        public async Task TestClassWithMonoCecilWithOrOperatorOverloadAsync()
        {
            await TestClassAsync(typeof(ClassWithOrOperatorOverload));
        }

        [TestMethod]
        public async Task TestClassWithMonoCecilWithPlusOperatorOverloadAsync()
        {
            await TestClassAsync(typeof(ClassWithPlusOperatorOverload));
        }

        [TestMethod]
        public async Task TestClassWithMonoCecilWithRightShiftOperatorOverloadAsync()
        {
            await TestClassAsync(typeof(ClassWithRightShiftOperatorOverload));
        }

        [TestMethod]
        public async Task TestClassWithMonoCecilWithTrueAndFalseOperatorOverloadsAsync()
        {
            await TestClassAsync(typeof(ClassWithTrueAndFalseOperatorOverloads));
        }

        [TestMethod]
        public async Task TestClassWithMonoCecilWithUnaryMinusOperatorOverloadAsync()
        {
            await TestClassAsync(typeof(ClassWithUnaryMinusOperatorOverload));
        }

        [TestMethod]
        public async Task TestClassWithMonoCecilWithUnaryPlusOperatorOverloadAsync()
        {
            await TestClassAsync(typeof(ClassWithUnaryPlusOperatorOverload));
        }
    }
}
