using CSharpDom.Common;
using CSharpDom.Reflection;
using CSharpDom.Reflection.Internal;
using CSharpDom.Tests.Common;
using CSharpDom.TestTarget.Classes;
using CSharpDom.TestTarget.Classes.NestedAbstractClasses;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Threading.Tasks;

namespace CSharpDom.Tests.Reflection
{
    [TestClass]
    public sealed partial class ClassNestedAbstractClassWithReflectionTests : AbstractSolutionTests<ProjectWithReflection>
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
        public async Task TestClassWithReflectionWithNestedAbstractClassWith1Attribute()
        {
            await TestClassAsync(typeof(ClassWithNestedAbstractClassWith1Attribute));
        }

        [TestMethod]
        public async Task TestClassWithReflectionWithNestedAbstractClassWith1GenericParameter()
        {
            await TestClassAsync(typeof(ClassWithNestedAbstractClassWith1GenericParameter));
        }

        [TestMethod]
        public async Task TestClassWithReflectionWithNestedAbstractClassWith1ImplementedInterface()
        {
            await TestClassAsync(typeof(ClassWithNestedAbstractClassWith1ImplementedInterface));
        }

        [TestMethod]
        public async Task TestClassWithReflectionWithNestedAbstractClassWith2AttributesIn1AttributeGroup()
        {
            await TestClassAsync(typeof(ClassWithNestedAbstractClassWith2AttributesIn1AttributeGroup));
        }

        [TestMethod]
        public async Task TestClassWithReflectionWithNestedAbstractClassWith2AttributesIn2AttributeGroups()
        {
            await TestClassAsync(typeof(ClassWithNestedAbstractClassWith2AttributesIn2AttributeGroups));
        }

        [TestMethod]
        public async Task TestClassWithReflectionWithNestedAbstractClassWith2GenericParameters()
        {
            await TestClassAsync(typeof(ClassWithNestedAbstractClassWith2GenericParameters));
        }

        [TestMethod]
        public async Task TestClassWithReflectionWithNestedAbstractClassWith2ImplementedInterfaces()
        {
            await TestClassAsync(typeof(ClassWithNestedAbstractClassWith2ImplementedInterfaces));
        }

        [TestMethod]
        public async Task TestClassWithReflectionWithNestedAbstractClassWithBaseClass()
        {
            await TestClassAsync(typeof(ClassWithNestedAbstractClassWithBaseClass));
        }

        [TestMethod]
        public async Task TestClassWithReflectionWithNestedAbstractClassWithGenericParameterClassAndEmptyConstructorConstraints()
        {
            await TestClassAsync(typeof(ClassWithNestedAbstractClassWithGenericParameterClassAndEmptyConstructorConstraints));
        }

        [TestMethod]
        public async Task TestClassWithReflectionWithNestedAbstractClassWithGenericParameterClassAndInterfaceAndEmptyConstructorConstraints()
        {
            await TestClassAsync(typeof(ClassWithNestedAbstractClassWithGenericParameterClassAndInterfaceAndEmptyConstructorConstraints));
        }

        [TestMethod]
        public async Task TestClassWithReflectionWithNestedAbstractClassWithGenericParameterBaseClassConstraint()
        {
            await TestClassAsync(typeof(ClassWithNestedAbstractClassWithGenericParameterBaseClassConstraint));
        }

        [TestMethod]
        public async Task TestClassWithReflectionWithNestedAbstractClassWithGenericParameterClassConstraint()
        {
            await TestClassAsync(typeof(ClassWithNestedAbstractClassWithGenericParameterClassConstraint));
        }

        [TestMethod]
        public async Task TestClassWithReflectionWithNestedAbstractClassWithGenericParameterEmptyConstructorConstraint()
        {
            await TestClassAsync(typeof(ClassWithNestedAbstractClassWithGenericParameterEmptyConstructorConstraint));
        }

        [TestMethod]
        public async Task TestClassWithReflectionWithNestedAbstractClassWithGenericParameterGenericParameterConstraint()
        {
            await TestClassAsync(typeof(ClassWithNestedAbstractClassWithGenericParameterGenericParameterConstraint));
        }

        [TestMethod]
        public async Task TestClassWithReflectionWithNestedAbstractClassWithGenericParameterInterfaceConstraint()
        {
            await TestClassAsync(typeof(ClassWithNestedAbstractClassWithGenericParameterInterfaceConstraint));
        }

        [TestMethod]
        public async Task TestClassWithReflectionWithNestedAbstractClassWithGenericParameterStructConstraint()
        {
            await TestClassAsync(typeof(ClassWithNestedAbstractClassWithGenericParameterStructConstraint));
        }

        [TestMethod]
        public async Task TestClassWithReflectionWithInternalNestedAbstractClass()
        {
            await TestClassAsync(typeof(ClassWithInternalNestedAbstractClass));
        }

        [TestMethod]
        public async Task TestClassWithReflectionWithPrivateNestedAbstractClass()
        {
            await TestClassAsync(typeof(ClassWithPrivateNestedAbstractClass));
        }

        [TestMethod]
        public async Task TestClassWithReflectionWithProtectedNestedAbstractClass()
        {
            await TestClassAsync(typeof(ClassWithProtectedNestedAbstractClass));
        }

        [TestMethod]
        public async Task TestClassWithReflectionWithProtectedInternalNestedAbstractClass()
        {
            await TestClassAsync(typeof(ClassWithProtectedInternalNestedAbstractClass));
        }

        [TestMethod]
        public async Task TestClassWithReflectionWithPublicNestedAbstractClass()
        {
            await TestClassAsync(typeof(ClassWithPublicNestedAbstractClass));
        }
    }
}