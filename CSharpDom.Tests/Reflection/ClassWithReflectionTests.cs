using CSharpDom.Common;
using CSharpDom.Reflection;
using CSharpDom.Reflection.Internal;
using CSharpDom.Tests.Common;
using CSharpDom.TestTarget.Classes;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Threading.Tasks;

namespace CSharpDom.Tests.Reflection
{
    [TestClass]
    public sealed class ClassWithReflectionTests : AbstractClassTests<ProjectWithReflection>
    {
        private ISolution<ProjectWithReflection> solution;

        [TestInitialize]
        public void SetUp()
        {
            solution = new AssemblyWithReflection(typeof(PublicClass).Assembly).AsSolution();
        }

        public override ISolution<ProjectWithReflection> Solution
        {
            get { return solution; }
        }

        [TestMethod]
        public async Task TestPublicClassWithReflectionAsync()
        {
            await TestClassAsync(typeof(PublicClass));
        }

        [TestMethod]
        public async Task TestInternalClassWithReflectionAsync()
        {
            await TestClassAsync(typeof(InternalClass));
        }

        [TestMethod]
        public async Task TestClassWithReflectionWith1AttributeAsync()
        {
            await TestClassAsync(typeof(ClassWith1Attribute));
        }

        [TestMethod]
        public async Task TestClassWithReflectionWith1GenericParameterAsync()
        {
            await TestClassAsync(typeof(ClassWith1GenericParameter<>));
        }

        [TestMethod]
        public async Task TestClassWithReflectionWith1ImplementedInterfaceAsync()
        {
            await TestClassAsync(typeof(ClassWith1ImplementedInterface));
        }

        [TestMethod]
        public async Task TestClassWithReflectionWith2AttributesAsync()
        {
            await TestClassAsync(typeof(ClassWith2AttributesIn2AttributeGroups));
        }

        [TestMethod]
        public async Task TestClassWithReflectionWith2GenericParametersAsync()
        {
            await TestClassAsync(typeof(ClassWith2GenericParameters<,>));
        }

        [TestMethod]
        public async Task TestClassWithReflectionWith2ImplementedInterfacesAsync()
        {
            await TestClassAsync(typeof(ClassWith2ImplementedInterfaces));
        }

        [TestMethod]
        public async Task TestClassWithReflectionWithBaseClassAsync()
        {
            await TestClassAsync(typeof(ClassWithBaseClass));
        }

        [TestMethod]
        public async Task TestClassWithReflectionWithDestructorAsync()
        {
            await TestClassAsync(typeof(ClassWithDestructor));
        }

        [TestMethod]
        public async Task TestClassWithReflectionWithExplicitConversionOperatorAsync()
        {
            await TestClassAsync(typeof(ClassWithExplicitConversionOperator));
        }

        [TestMethod]
        public async Task TestClassWithReflectionWithGenericParameterBaseClassConstraintAsync()
        {
            await TestClassAsync(typeof(ClassWithGenericParameterBaseClassConstraint<>));
        }

        [TestMethod]
        public async Task TestClassWithReflectionWithGenericParameterClassAndEmptyConstructorConstraintsAsync()
        {
            await TestClassAsync(typeof(ClassWithGenericParameterClassAndEmptyConstructorConstraints<>));
        }

        [TestMethod]
        public async Task TestClassWithReflectionWithGenericParameterClassAndInterfaceAndEmptyConstructorConstraintsAsync()
        {
            await TestClassAsync(typeof(ClassWithGenericParameterClassAndInterfaceAndEmptyConstructorConstraints<>));
        }

        [TestMethod]
        public async Task TestClassWithReflectionWithGenericParameterClassConstraintAsync()
        {
            await TestClassAsync(typeof(ClassWithGenericParameterClassConstraint<>));
        }

        [TestMethod]
        public async Task TestClassWithReflectionWithGenericParameterEmptyConstructorConstraintAsync()
        {
            await TestClassAsync(typeof(ClassWithGenericParameterEmptyConstructorConstraint<>));
        }

        [TestMethod]
        public async Task TestClassWithReflectionWithGenericParameterGenericParameterConstraintAsync()
        {
            await TestClassAsync(typeof(ClassWithGenericParameterGenericParameterConstraint<,>));
        }

        [TestMethod]
        public async Task TestClassWithReflectionWithGenericParameterInterfaceConstraintAsync()
        {
            await TestClassAsync(typeof(ClassWithGenericParameterInterfaceConstraint<>));
        }

        [TestMethod]
        public async Task TestClassWithReflectionWithGenericParameterStructConstraintAsync()
        {
            await TestClassAsync(typeof(ClassWithGenericParameterStructConstraint<>));
        }

        [TestMethod]
        public async Task TestClassWithReflectionWithImplicitConversionOperatorConstraintAsync()
        {
            await TestClassAsync(typeof(ClassWithImplicitConversionOperator));
        }
    }
}
