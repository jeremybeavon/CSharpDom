using CSharpDom.Common;
using CSharpDom.Mono.Cecil;
using CSharpDom.Mono.Cecil.Internal;
using CSharpDom.Tests.Common;
using CSharpDom.TestTarget.AbstractClasses;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Mono.Cecil;
using System.Threading.Tasks;

namespace CSharpDom.Tests.Mono.Cecil
{
    [TestClass]
    public sealed class AbstractClassWithMonoCecilTests : AbstractSolutionTests<ProjectWithMonoCecil>
    {
        private ISolution<ProjectWithMonoCecil> solution;

        public override ISolution<ProjectWithMonoCecil> Solution
        {
            get { return solution; }
        }

        [TestInitialize]
        public void SetUp()
        {
            solution = new AssemblyWithMonoCecil(AssemblyDefinition.ReadAssembly(typeof(PublicAbstractClass).Assembly.Location)).AsSolution();
        }

        [TestMethod]
        public async Task TestPublicAbstractClassWithMonoCecilAsync()
        {
            await TestAbstractClassAsync(typeof(PublicAbstractClass));
        }

        [TestMethod]
        public async Task TestInternalAbstractClassWithMonoCecilAsync()
        {
            await TestAbstractClassAsync(typeof(InternalAbstractClass));
        }

        [TestMethod]
        public async Task TestAbstractClassWithMonoCecilWith1AttributeAsync()
        {
            await TestAbstractClassAsync(typeof(AbstractClassWith1Attribute));
        }

        [TestMethod]
        public async Task TestAbstractClassWithMonoCecilWith1GenericParameterAsync()
        {
            await TestAbstractClassAsync(typeof(AbstractClassWith1GenericParameter<>));
        }

        [TestMethod]
        public async Task TestAbstractClassWithMonoCecilWith1ImplementedInterfaceAsync()
        {
            await TestAbstractClassAsync(typeof(AbstractClassWith1ImplementedInterface));
        }

        [TestMethod]
        public async Task TestAbstractClassWithMonoCecilWith2AttributesAsync()
        {
            await TestAbstractClassAsync(typeof(AbstractClassWith2AttributesIn2AttributeGroups));
        }

        [TestMethod]
        public async Task TestAbstractClassWithMonoCecilWith2GenericParametersAsync()
        {
            await TestAbstractClassAsync(typeof(AbstractClassWith2GenericParameters<,>));
        }

        [TestMethod]
        public async Task TestAbstractClassWithMonoCecilWith2ImplementedInterfacesAsync()
        {
            await TestAbstractClassAsync(typeof(AbstractClassWith2ImplementedInterfaces));
        }

        [TestMethod]
        public async Task TestAbstractClassWithMonoCecilWithBaseClassAsync()
        {
            await TestAbstractClassAsync(typeof(AbstractClassWithBaseClass));
        }

        [TestMethod]
        public async Task TestAbstractClassWithMonoCecilWithGenericParameterBaseClassConstraintAsync()
        {
            await TestAbstractClassAsync(typeof(AbstractClassWithGenericParameterBaseClassConstraint<>));
        }

        [TestMethod]
        public async Task TestAbstractClassWithMonoCecilWithGenericParameterClassAndEmptyConstructorConstraintsAsync()
        {
            await TestAbstractClassAsync(typeof(AbstractClassWithGenericParameterClassAndEmptyConstructorConstraints<>));
        }

        [TestMethod]
        public async Task TestAbstractClassWithMonoCecilWithGenericParameterClassAndInterfaceAndEmptyConstructorConstraintsAsync()
        {
            await TestAbstractClassAsync(typeof(AbstractClassWithGenericParameterClassAndInterfaceAndEmptyConstructorConstraints<>));
        }

        [TestMethod]
        public async Task TestAbstractClassWithMonoCecilWithGenericParameterClassConstraintAsync()
        {
            await TestAbstractClassAsync(typeof(AbstractClassWithGenericParameterClassConstraint<>));
        }

        [TestMethod]
        public async Task TestAbstractClassWithMonoCecilWithGenericParameterEmptyConstructorConstraintAsync()
        {
            await TestAbstractClassAsync(typeof(AbstractClassWithGenericParameterEmptyConstructorConstraint<>));
        }

        [TestMethod]
        public async Task TestAbstractClassWithMonoCecilWithGenericParameterGenericParameterConstraintAsync()
        {
            await TestAbstractClassAsync(typeof(AbstractClassWithGenericParameterGenericParameterConstraint<,>));
        }

        [TestMethod]
        public async Task TestAbstractClassWithMonoCecilWithGenericParameterInterfaceConstraintAsync()
        {
            await TestAbstractClassAsync(typeof(AbstractClassWithGenericParameterInterfaceConstraint<>));
        }

        [TestMethod]
        public async Task TestAbstractClassWithMonoCecilWithGenericParameterStructConstraintAsync()
        {
            await TestAbstractClassAsync(typeof(AbstractClassWithGenericParameterStructConstraint<>));
        }
    }
}
