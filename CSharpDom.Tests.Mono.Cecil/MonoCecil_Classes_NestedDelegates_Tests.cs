using CSharpDom.TestTarget.Classes.NestedDelegates;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Threading.Tasks;

namespace CSharpDom.Tests.Mono.Cecil
{
    [TestClass]
    public sealed class MonoCecil_Classes_NestedDelegates_Tests : AbstractSolutionWithMonoCecilTests
    {
        [TestMethod]
        public void TestClassWithNestedDelegateWith1AttributeUsingMonoCecil()
        {
            TestClass(typeof(ClassWithNestedDelegateWith1Attribute));
        }

        [TestMethod]
        public void TestClassWithNestedDelegateWith1GenericParameterUsingMonoCecil()
        {
            TestClass(typeof(ClassWithNestedDelegateWith1GenericParameter));
        }

        [TestMethod]
        public void TestClassWithNestedDelegateWith2AttributesIn2AttributeGroupsUsingMonoCecil()
        {
            TestClass(typeof(ClassWithNestedDelegateWith2AttributesIn2AttributeGroups));
        }

        [TestMethod]
        public void TestClassWithNestedDelegateWith2GenericParametersUsingMonoCecil()
        {
            TestClass(typeof(ClassWithNestedDelegateWith2GenericParameters));
        }

        [TestMethod]
        public void TestClassWithNestedDelegateWithGenericParameterBaseClassConstraintUsingMonoCecil()
        {
            TestClass(typeof(ClassWithNestedDelegateWithGenericParameterBaseClassConstraint));
        }

        [TestMethod]
        public void TestClassWithNestedDelegateWithGenericParameterClassAndEmptyConstructorConstraintsUsingMonoCecil()
        {
            TestClass(typeof(ClassWithNestedDelegateWithGenericParameterClassAndEmptyConstructorConstraints));
        }

        [TestMethod]
        public void TestClassWithNestedDelegateWithGenericParameterClassAndInterfaceAndEmptyConstructorConstraintsUsingMonoCecil()
        {
            TestClass(typeof(ClassWithNestedDelegateWithGenericParameterClassAndInterfaceAndEmptyConstructorConstraints));
        }

        [TestMethod]
        public void TestClassWithNestedDelegateWithGenericParameterClassConstraintUsingMonoCecil()
        {
            TestClass(typeof(ClassWithNestedDelegateWithGenericParameterClassConstraint));
        }

        [TestMethod]
        public void TestClassWithNestedDelegateWithGenericParameterEmptyConstructorConstraintUsingMonoCecil()
        {
            TestClass(typeof(ClassWithNestedDelegateWithGenericParameterEmptyConstructorConstraint));
        }

        [TestMethod]
        public void TestClassWithNestedDelegateWithGenericParameterGenericParameterConstraintUsingMonoCecil()
        {
            TestClass(typeof(ClassWithNestedDelegateWithGenericParameterGenericParameterConstraint));
        }

        [TestMethod]
        public void TestClassWithNestedDelegateWithGenericParameterInterfaceConstraintUsingMonoCecil()
        {
            TestClass(typeof(ClassWithNestedDelegateWithGenericParameterInterfaceConstraint));
        }

        [TestMethod]
        public void TestClassWithNestedDelegateWithGenericParameterStructConstraintUsingMonoCecil()
        {
            TestClass(typeof(ClassWithNestedDelegateWithGenericParameterStructConstraint));
        }

        [TestMethod]
        public void TestClassWithProtectedNestedDelegateUsingMonoCecil()
        {
            TestClass(typeof(ClassWithProtectedNestedDelegate));
        }

        [TestMethod]
        public void TestClassWithPrivateNestedDelegateUsingMonoCecil()
        {
            TestClass(typeof(ClassWithPrivateNestedDelegate));
        }

        [TestMethod]
        public void TestClassWithProtectedInternalNestedDelegateUsingMonoCecil()
        {
            TestClass(typeof(ClassWithProtectedInternalNestedDelegate));
        }

        [TestMethod]
        public void TestClassWithInternalNestedDelegateUsingMonoCecil()
        {
            TestClass(typeof(ClassWithInternalNestedDelegate));
        }

        [TestMethod]
        public void TestClassWithNestedDelegateWithParametersWithAttributesUsingMonoCecil()
        {
            TestClass(typeof(ClassWithNestedDelegateWithParametersWithAttributes));
        }

        [TestMethod]
        public void TestClassWithNestedDelegateWithParametersWithModifiersUsingMonoCecil()
        {
            TestClass(typeof(ClassWithNestedDelegateWithParametersWithModifiers));
        }

        [TestMethod]
        public void TestClassWithPublicNestedDelegateUsingMonoCecil()
        {
            TestClass(typeof(ClassWithPublicNestedDelegate));
        }
    }
}
