using CSharpDom.Common;
using CSharpDom.Mono.Cecil;
using CSharpDom.Mono.Cecil.Internal;
using CSharpDom.Tests.Common;
using CSharpDom.TestTarget.Classes;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Mono.Cecil;
using System.Threading.Tasks;

namespace CSharpDom.Tests.Mono.Cecil
{
    [TestClass]
    public sealed class ClassWithMonoCecilTests : AbstractSolutionTests<ProjectWithMonoCecil>
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
        public async Task TestPublicClassWithMonoCecilAsync()
        {
            await TestClassAsync(typeof(PublicClass));
        }

        [TestMethod]
        public async Task TestInternalClassWithMonoCecilAsync()
        {
            await TestClassAsync(typeof(InternalClass));
        }

        [TestMethod]
        public async Task TestClassWithMonoCecilWith1AttributeAsync()
        {
            await TestClassAsync(typeof(ClassWith1Attribute));
        }

        [TestMethod]
        public async Task TestClassWithMonoCecilWith1GenericParameterAsync()
        {
            await TestClassAsync(typeof(ClassWith1GenericParameter<>));
        }

        [TestMethod]
        public async Task TestClassWithMonoCecilWith1ImplementedInterfaceAsync()
        {
            await TestClassAsync(typeof(ClassWith1ImplementedInterface));
        }

        [TestMethod]
        public async Task TestClassWithMonoCecilWith2AttributesAsync()
        {
            await TestClassAsync(typeof(ClassWith2AttributesIn2AttributeGroups));
        }

        [TestMethod]
        public async Task TestClassWithMonoCecilWith2GenericParametersAsync()
        {
            await TestClassAsync(typeof(ClassWith2GenericParameters<,>));
        }

        [TestMethod]
        public async Task TestClassWithMonoCecilWith2ImplementedInterfacesAsync()
        {
            await TestClassAsync(typeof(ClassWith2ImplementedInterfaces));
        }

        [TestMethod]
        public async Task TestClassWithMonoCecilWithBaseClassAsync()
        {
            await TestClassAsync(typeof(ClassWithBaseClass));
        }

        [TestMethod]
        public async Task TestClassWithMonoCecilWithGenericParameterBaseClassConstraintAsync()
        {
            await TestClassAsync(typeof(ClassWithGenericParameterBaseClassConstraint<>));
        }

        [TestMethod]
        public async Task TestClassWithMonoCecilWithGenericParameterClassAndEmptyConstructorConstraintsAsync()
        {
            await TestClassAsync(typeof(ClassWithGenericParameterClassAndEmptyConstructorConstraints<>));
        }

        [TestMethod]
        public async Task TestClassWithMonoCecilWithGenericParameterClassAndInterfaceAndEmptyConstructorConstraintsAsync()
        {
            await TestClassAsync(typeof(ClassWithGenericParameterClassAndInterfaceAndEmptyConstructorConstraints<>));
        }

        [TestMethod]
        public async Task TestClassWithMonoCecilWithGenericParameterClassConstraintAsync()
        {
            await TestClassAsync(typeof(ClassWithGenericParameterClassConstraint<>));
        }

        [TestMethod]
        public async Task TestClassWithMonoCecilWithGenericParameterEmptyConstructorConstraintAsync()
        {
            await TestClassAsync(typeof(ClassWithGenericParameterEmptyConstructorConstraint<>));
        }

        [TestMethod]
        public async Task TestClassWithMonoCecilWithGenericParameterGenericParameterConstraintAsync()
        {
            await TestClassAsync(typeof(ClassWithGenericParameterGenericParameterConstraint<,>));
        }

        [TestMethod]
        public async Task TestClassWithMonoCecilWithGenericParameterInterfaceConstraintAsync()
        {
            await TestClassAsync(typeof(ClassWithGenericParameterInterfaceConstraint<>));
        }

        [TestMethod]
        public async Task TestClassWithMonoCecilWithGenericParameterStructConstraintAsync()
        {
            await TestClassAsync(typeof(ClassWithGenericParameterStructConstraint<>));
        }
    }
}
