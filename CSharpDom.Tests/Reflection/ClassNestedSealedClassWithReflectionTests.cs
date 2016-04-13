using CSharpDom.Common;
using CSharpDom.Reflection;
using CSharpDom.Reflection.Internal;
using CSharpDom.Tests.Common;
using CSharpDom.TestTarget.Classes;
using CSharpDom.TestTarget.Classes.NestedSealedClasses;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Threading.Tasks;

namespace CSharpDom.Tests.Reflection
{
    [TestClass]
    public sealed partial class ClassNestedSealedClassWithReflectionTests : AbstractSolutionTests<ProjectWithReflection>
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
        public async Task TestClassWithReflectionWithNestedSealedClassWith1Attribute()
        {
            await TestClassAsync(typeof(ClassWithNestedSealedClassWith1Attribute));
        }

        [TestMethod]
        public async Task TestClassWithReflectionWithNestedSealedClassWith1GenericParameter()
        {
            await TestClassAsync(typeof(ClassWithNestedSealedClassWith1GenericParameter));
        }

        [TestMethod]
        public async Task TestClassWithReflectionWithNestedSealedClassWith1ImplementedInterface()
        {
            await TestClassAsync(typeof(ClassWithNestedSealedClassWith1ImplementedInterface));
        }

        [TestMethod]
        public async Task TestClassWithReflectionWithNestedSealedClassWith2AttributesIn1AttributeGroup()
        {
            await TestClassAsync(typeof(ClassWithNestedSealedClassWith2AttributesIn1AttributeGroup));
        }

        [TestMethod]
        public async Task TestClassWithReflectionWithNestedSealedClassWith2AttributesIn2AttributeGroups()
        {
            await TestClassAsync(typeof(ClassWithNestedSealedClassWith2AttributesIn2AttributeGroups));
        }

        [TestMethod]
        public async Task TestClassWithReflectionWithNestedSealedClassWith2GenericParameters()
        {
            await TestClassAsync(typeof(ClassWithNestedSealedClassWith2GenericParameters));
        }

        [TestMethod]
        public async Task TestClassWithReflectionWithNestedSealedClassWith2ImplementedInterfaces()
        {
            await TestClassAsync(typeof(ClassWithNestedSealedClassWith2ImplementedInterfaces));
        }

        [TestMethod]
        public async Task TestClassWithReflectionWithNestedSealedClassWithBaseClass()
        {
            await TestClassAsync(typeof(ClassWithNestedSealedClassWithBaseClass));
        }

        [TestMethod]
        public async Task TestClassWithReflectionWithNestedSealedClassWithGenericParameterClassAndEmptyConstructorConstraints()
        {
            await TestClassAsync(typeof(ClassWithNestedSealedClassWithGenericParameterClassAndEmptyConstructorConstraints));
        }

        [TestMethod]
        public async Task TestClassWithReflectionWithNestedSealedClassWithGenericParameterClassAndInterfaceAndEmptyConstructorConstraints()
        {
            await TestClassAsync(typeof(ClassWithNestedSealedClassWithGenericParameterClassAndInterfaceAndEmptyConstructorConstraints));
        }

        [TestMethod]
        public async Task TestClassWithReflectionWithNestedSealedClassWithGenericParameterBaseClassConstraint()
        {
            await TestClassAsync(typeof(ClassWithNestedSealedClassWithGenericParameterBaseClassConstraint));
        }

        [TestMethod]
        public async Task TestClassWithReflectionWithNestedSealedClassWithGenericParameterClassConstraint()
        {
            await TestClassAsync(typeof(ClassWithNestedSealedClassWithGenericParameterClassConstraint));
        }

        [TestMethod]
        public async Task TestClassWithReflectionWithNestedSealedClassWithGenericParameterEmptyConstructorConstraint()
        {
            await TestClassAsync(typeof(ClassWithNestedSealedClassWithGenericParameterEmptyConstructorConstraint));
        }

        [TestMethod]
        public async Task TestClassWithReflectionWithNestedSealedClassWithGenericParameterGenericParameterConstraint()
        {
            await TestClassAsync(typeof(ClassWithNestedSealedClassWithGenericParameterGenericParameterConstraint));
        }

        [TestMethod]
        public async Task TestClassWithReflectionWithNestedSealedClassWithGenericParameterInterfaceConstraint()
        {
            await TestClassAsync(typeof(ClassWithNestedSealedClassWithGenericParameterInterfaceConstraint));
        }

        [TestMethod]
        public async Task TestClassWithReflectionWithNestedSealedClassWithGenericParameterStructConstraint()
        {
            await TestClassAsync(typeof(ClassWithNestedSealedClassWithGenericParameterStructConstraint));
        }

        [TestMethod]
        public async Task TestClassWithReflectionWithInternalNestedSealedClass()
        {
            await TestClassAsync(typeof(ClassWithInternalNestedSealedClass));
        }

        [TestMethod]
        public async Task TestClassWithReflectionWithPrivateNestedSealedClass()
        {
            await TestClassAsync(typeof(ClassWithPrivateNestedSealedClass));
        }

        [TestMethod]
        public async Task TestClassWithReflectionWithProtectedNestedSealedClass()
        {
            await TestClassAsync(typeof(ClassWithProtectedNestedSealedClass));
        }

        [TestMethod]
        public async Task TestClassWithReflectionWithProtectedInternalNestedSealedClass()
        {
            await TestClassAsync(typeof(ClassWithProtectedInternalNestedSealedClass));
        }

        [TestMethod]
        public async Task TestClassWithReflectionWithPublicNestedSealedClass()
        {
            await TestClassAsync(typeof(ClassWithPublicNestedSealedClass));
        }
    }
}