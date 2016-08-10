using CSharpDom.TestTarget.Classes.NestedClasses.NestedClasses;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Threading.Tasks;

namespace CSharpDom.Tests.Mono.Cecil
{
    [TestClass]
    public sealed class MonoCecil_Classes_NestedClasses_NestedClasses_Tests : AbstractSolutionWithMonoCecilTests
    {
        [TestMethod]
        public void TestClassWithNestedClassWithNestedClassWith1AttributeUsingMonoCecil()
        {
            TestClassAsync(typeof(ClassWithNestedClassWithNestedClassWith1Attribute));
        }

        [TestMethod]
        public void TestClassWithNestedClassWithNestedClassWith1GenericParameterUsingMonoCecil()
        {
            TestClassAsync(typeof(ClassWithNestedClassWithNestedClassWith1GenericParameter));
        }

        [TestMethod]
        public void TestClassWithNestedClassWithNestedClassWith1ImplementedInterfaceUsingMonoCecil()
        {
            TestClassAsync(typeof(ClassWithNestedClassWithNestedClassWith1ImplementedInterface));
        }

        [TestMethod]
        public void TestClassWithNestedClassWithNestedClassWith2AttributesIn2AttributeGroupsUsingMonoCecil()
        {
            TestClassAsync(typeof(ClassWithNestedClassWithNestedClassWith2AttributesIn2AttributeGroups));
        }

        [TestMethod]
        public void TestClassWithNestedClassWithNestedClassWith2GenericParametersUsingMonoCecil()
        {
            TestClassAsync(typeof(ClassWithNestedClassWithNestedClassWith2GenericParameters));
        }

        [TestMethod]
        public void TestClassWithNestedClassWithNestedClassWith2ImplementedInterfacesUsingMonoCecil()
        {
            TestClassAsync(typeof(ClassWithNestedClassWithNestedClassWith2ImplementedInterfaces));
        }

        [TestMethod]
        public void TestClassWithNestedClassWithNestedClassWithBaseClassUsingMonoCecil()
        {
            TestClassAsync(typeof(ClassWithNestedClassWithNestedClassWithBaseClass));
        }

        [TestMethod]
        public void TestClassWithNestedClassWithNestedClassWithGenericParameterClassAndEmptyConstructorConstraintsUsingMonoCecil()
        {
            TestClassAsync(typeof(ClassWithNestedClassWithNestedClassWithGenericParameterClassAndEmptyConstructorConstraints));
        }

        [TestMethod]
        public void TestClassWithNestedClassWithNestedClassWithGenericParameterClassAndInterfaceAndEmptyConstructorConstraintsUsingMonoCecil()
        {
            TestClassAsync(typeof(ClassWithNestedClassWithNestedClassWithGenericParameterClassAndInterfaceAndEmptyConstructorConstraints));
        }

        [TestMethod]
        public void TestClassWithNestedClassWithNestedClassWithGenericParameterBaseClassConstraintUsingMonoCecil()
        {
            TestClassAsync(typeof(ClassWithNestedClassWithNestedClassWithGenericParameterBaseClassConstraint));
        }

        [TestMethod]
        public void TestClassWithNestedClassWithNestedClassWithGenericParameterClassConstraintUsingMonoCecil()
        {
            TestClassAsync(typeof(ClassWithNestedClassWithNestedClassWithGenericParameterClassConstraint));
        }

        [TestMethod]
        public void TestClassWithNestedClassWithNestedClassWithGenericParameterEmptyConstructorConstraintUsingMonoCecil()
        {
            TestClassAsync(typeof(ClassWithNestedClassWithNestedClassWithGenericParameterEmptyConstructorConstraint));
        }

        [TestMethod]
        public void TestClassWithNestedClassWithNestedClassWithGenericParameterGenericParameterConstraintUsingMonoCecil()
        {
            TestClassAsync(typeof(ClassWithNestedClassWithNestedClassWithGenericParameterGenericParameterConstraint));
        }

        [TestMethod]
        public void TestClassWithNestedClassWithNestedClassWithGenericParameterInterfaceConstraintUsingMonoCecil()
        {
            TestClassAsync(typeof(ClassWithNestedClassWithNestedClassWithGenericParameterInterfaceConstraint));
        }

        [TestMethod]
        public void TestClassWithNestedClassWithNestedClassWithGenericParameterStructConstraintUsingMonoCecil()
        {
            TestClassAsync(typeof(ClassWithNestedClassWithNestedClassWithGenericParameterStructConstraint));
        }

        [TestMethod]
        public void TestClassWithNestedClassWithInternalNestedClassUsingMonoCecil()
        {
            TestClassAsync(typeof(ClassWithNestedClassWithInternalNestedClass));
        }

        [TestMethod]
        public void TestClassWithNestedClassWithPrivateNestedClassUsingMonoCecil()
        {
            TestClassAsync(typeof(ClassWithNestedClassWithPrivateNestedClass));
        }

        [TestMethod]
        public void TestClassWithNestedClassWithProtectedNestedClassUsingMonoCecil()
        {
            TestClassAsync(typeof(ClassWithNestedClassWithProtectedNestedClass));
        }

        [TestMethod]
        public void TestClassWithNestedClassWithProtectedInternalNestedClassUsingMonoCecil()
        {
            TestClassAsync(typeof(ClassWithNestedClassWithProtectedInternalNestedClass));
        }

        [TestMethod]
        public void TestClassWithNestedClassWithPublicNestedClassUsingMonoCecil()
        {
            TestClassAsync(typeof(ClassWithNestedClassWithPublicNestedClass));
        }
    }
}
