using CSharpDom.Common;
using CSharpDom.Reflection;
using CSharpDom.Reflection.Internal;
using CSharpDom.Tests.Common;
using CSharpDom.TestTarget.Classes;
using CSharpDom.TestTarget.Classes.NestedClasses;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Threading.Tasks;

namespace CSharpDom.Tests.Reflection
{
    [TestClass]
    public sealed partial class ClassNestedClassWithReflectionTests : AbstractSolutionTests<ProjectWithReflection>
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
        public async Task TestClassWithReflectionWithNestedClassWith1Attribute()
        {
            await TestClassAsync(typeof(ClassWithNestedClassWith1Attribute));
        }

        [TestMethod]
        public async Task TestClassWithReflectionWithNestedClassWith1GenericParameter()
        {
            await TestClassAsync(typeof(ClassWithNestedClassWith1GenericParameter));
        }

        [TestMethod]
        public async Task TestClassWithReflectionWithNestedClassWith1ImplementedInterface()
        {
            await TestClassAsync(typeof(ClassWithNestedClassWith1ImplementedInterface));
        }

        [TestMethod]
        public async Task TestClassWithReflectionWithNestedClassWith2AttributesIn1AttributeGroup()
        {
            await TestClassAsync(typeof(ClassWithNestedClassWith2AttributesIn1AttributeGroup));
        }

        [TestMethod]
        public async Task TestClassWithReflectionWithNestedClassWith2AttributesIn2AttributeGroups()
        {
            await TestClassAsync(typeof(ClassWithNestedClassWith2AttributesIn2AttributeGroups));
        }

        [TestMethod]
        public async Task TestClassWithReflectionWithNestedClassWith2GenericParameters()
        {
            await TestClassAsync(typeof(ClassWithNestedClassWith2GenericParameters));
        }

        [TestMethod]
        public async Task TestClassWithReflectionWithNestedClassWith2ImplementedInterfaces()
        {
            await TestClassAsync(typeof(ClassWithNestedClassWith2ImplementedInterfaces));
        }

        [TestMethod]
        public async Task TestClassWithReflectionWithNestedClassWithBaseClass()
        {
            await TestClassAsync(typeof(ClassWithNestedClassWithBaseClass));
        }

        [TestMethod]
        public async Task TestClassWithReflectionWithNestedClassWithGenericParameterClassAndEmptyConstructorConstraints()
        {
            await TestClassAsync(typeof(ClassWithNestedClassWithGenericParameterClassAndEmptyConstructorConstraints));
        }

        [TestMethod]
        public async Task TestClassWithReflectionWithNestedClassWithGenericParameterClassAndInterfaceAndEmptyConstructorConstraints()
        {
            await TestClassAsync(typeof(ClassWithNestedClassWithGenericParameterClassAndInterfaceAndEmptyConstructorConstraints));
        }

        [TestMethod]
        public async Task TestClassWithReflectionWithNestedClassWithGenericParameterBaseClassConstraint()
        {
            await TestClassAsync(typeof(ClassWithNestedClassWithGenericParameterBaseClassConstraint));
        }

        [TestMethod]
        public async Task TestClassWithReflectionWithNestedClassWithGenericParameterClassConstraint()
        {
            await TestClassAsync(typeof(ClassWithNestedClassWithGenericParameterClassConstraint));
        }

        [TestMethod]
        public async Task TestClassWithReflectionWithNestedClassWithGenericParameterEmptyConstructorConstraint()
        {
            await TestClassAsync(typeof(ClassWithNestedClassWithGenericParameterEmptyConstructorConstraint));
        }

        [TestMethod]
        public async Task TestClassWithReflectionWithNestedClassWithGenericParameterGenericParameterConstraint()
        {
            await TestClassAsync(typeof(ClassWithNestedClassWithGenericParameterGenericParameterConstraint));
        }

        [TestMethod]
        public async Task TestClassWithReflectionWithNestedClassWithGenericParameterInterfaceConstraint()
        {
            await TestClassAsync(typeof(ClassWithNestedClassWithGenericParameterInterfaceConstraint));
        }

        [TestMethod]
        public async Task TestClassWithReflectionWithNestedClassWithGenericParameterStructConstraint()
        {
            await TestClassAsync(typeof(ClassWithNestedClassWithGenericParameterStructConstraint));
        }

        [TestMethod]
        public async Task TestClassWithReflectionWithInternalNestedClass()
        {
            await TestClassAsync(typeof(ClassWithInternalNestedClass));
        }

        [TestMethod]
        public async Task TestClassWithReflectionWithPrivateNestedClass()
        {
            await TestClassAsync(typeof(ClassWithPrivateNestedClass));
        }

        [TestMethod]
        public async Task TestClassWithReflectionWithProtectedNestedClass()
        {
            await TestClassAsync(typeof(ClassWithProtectedNestedClass));
        }

        [TestMethod]
        public async Task TestClassWithReflectionWithProtectedInternalNestedClass()
        {
            await TestClassAsync(typeof(ClassWithProtectedInternalNestedClass));
        }

        [TestMethod]
        public async Task TestClassWithReflectionWithPublicNestedClass()
        {
            await TestClassAsync(typeof(ClassWithPublicNestedClass));
        }
    }
}