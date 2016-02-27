using CSharpDom.Common;
using CSharpDom.Reflection;
using CSharpDom.Reflection.Internal;
using CSharpDom.Tests.Common;
using CSharpDom.TestTarget.AbstractClasses;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Threading.Tasks;

namespace CSharpDom.Tests.Reflection
{
    [TestClass]
    public sealed class AbstractClassWithReflectionTests : AbstractSolutionTests<ProjectWithReflection>
    {
        private ISolution<ProjectWithReflection> solution;

        public override ISolution<ProjectWithReflection> Solution
        {
            get { return solution; }
        }

        [TestInitialize]
        public void SetUp()
        {
            solution = new AssemblyWithReflection(typeof(PublicAbstractClass).Assembly).AsSolution();
        }

        [TestMethod]
        public async Task TestPublicAbstractClassWithReflectionAsync()
        {
            await TestAbstractClassAsync(typeof(PublicAbstractClass));
        }

        [TestMethod]
        public async Task TestInternalAbstractClassWithReflectionAsync()
        {
            await TestAbstractClassAsync(typeof(InternalAbstractClass));
        }

        [TestMethod]
        public async Task TestAbstractClassWithReflectionWith1AttributeAsync()
        {
            await TestAbstractClassAsync(typeof(AbstractClassWith1Attribute));
        }

        [TestMethod]
        public async Task TestAbstractClassWithReflectionWith1GenericParameterAsync()
        {
            await TestAbstractClassAsync(typeof(AbstractClassWith1GenericParameter<>));
        }

        [TestMethod]
        public async Task TestAbstractClassWithReflectionWith1ImplementedInterfaceAsync()
        {
            await TestAbstractClassAsync(typeof(AbstractClassWith1ImplementedInterface));
        }

        [TestMethod]
        public async Task TestAbstractClassWithReflectionWith2AttributesAsync()
        {
            await TestAbstractClassAsync(typeof(AbstractClassWith2AttributesIn2AttributeGroups));
        }

        [TestMethod]
        public async Task TestAbstractClassWithReflectionWith2GenericParametersAsync()
        {
            await TestAbstractClassAsync(typeof(AbstractClassWith2GenericParameters<,>));
        }

        [TestMethod]
        public async Task TestAbstractClassWithReflectionWith2ImplementedInterfacesAsync()
        {
            await TestAbstractClassAsync(typeof(AbstractClassWith2ImplementedInterfaces));
        }

        [TestMethod]
        public async Task TestAbstractClassWithReflectionWithBaseClassAsync()
        {
            await TestAbstractClassAsync(typeof(AbstractClassWithBaseClass));
        }

        [TestMethod]
        public async Task TestAbstractClassWithReflectionWithGenericParameterBaseClassConstraintAsync()
        {
            await TestAbstractClassAsync(typeof(AbstractClassWithGenericParameterBaseClassConstraint<>));
        }

        [TestMethod]
        public async Task TestAbstractClassWithReflectionWithGenericParameterClassAndEmptyConstructorConstraintsAsync()
        {
            await TestAbstractClassAsync(typeof(AbstractClassWithGenericParameterClassAndEmptyConstructorConstraints<>));
        }

        [TestMethod]
        public async Task TestAbstractClassWithReflectionWithGenericParameterClassAndInterfaceAndEmptyConstructorConstraintsAsync()
        {
            await TestAbstractClassAsync(typeof(AbstractClassWithGenericParameterClassAndInterfaceAndEmptyConstructorConstraints<>));
        }

        [TestMethod]
        public async Task TestAbstractClassWithReflectionWithGenericParameterClassConstraintAsync()
        {
            await TestAbstractClassAsync(typeof(AbstractClassWithGenericParameterClassConstraint<>));
        }

        [TestMethod]
        public async Task TestAbstractClassWithReflectionWithGenericParameterEmptyConstructorConstraintAsync()
        {
            await TestAbstractClassAsync(typeof(AbstractClassWithGenericParameterEmptyConstructorConstraint<>));
        }

        [TestMethod]
        public async Task TestAbstractClassWithReflectionWithGenericParameterGenericParameterConstraintAsync()
        {
            await TestAbstractClassAsync(typeof(AbstractClassWithGenericParameterGenericParameterConstraint<,>));
        }

        [TestMethod]
        public async Task TestAbstractClassWithReflectionWithGenericParameterInterfaceConstraintAsync()
        {
            await TestAbstractClassAsync(typeof(AbstractClassWithGenericParameterInterfaceConstraint<>));
        }

        [TestMethod]
        public async Task TestAbstractClassWithReflectionWithGenericParameterStructConstraintAsync()
        {
            await TestAbstractClassAsync(typeof(AbstractClassWithGenericParameterStructConstraint<>));
        }
    }
}
