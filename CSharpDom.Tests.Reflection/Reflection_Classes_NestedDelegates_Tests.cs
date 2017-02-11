using CSharpDom.TestTarget.Classes.NestedDelegates;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Threading.Tasks;

namespace CSharpDom.Tests.Reflection
{
    [TestClass]
    public sealed class Reflection_Classes_NestedDelegates_Tests : AbstractSolutionWithReflectionTests
    {
        [TestMethod]
        public void TestClassWithNestedDelegateWith1AttributeUsingReflection()
        {
            TestClass(typeof(ClassWithNestedDelegateWith1Attribute));
        }

        [TestMethod]
        public void TestClassWithNestedDelegateWith1GenericParameterUsingReflection()
        {
            TestClass(typeof(ClassWithNestedDelegateWith1GenericParameter));
        }

        [TestMethod]
        public void TestClassWithNestedDelegateWith2AttributesIn2AttributeGroupsUsingReflection()
        {
            TestClass(typeof(ClassWithNestedDelegateWith2AttributesIn2AttributeGroups));
        }

        [TestMethod]
        public void TestClassWithNestedDelegateWith2GenericParametersUsingReflection()
        {
            TestClass(typeof(ClassWithNestedDelegateWith2GenericParameters));
        }

        [TestMethod]
        public void TestClassWithNestedDelegateWithGenericParameterBaseClassConstraintUsingReflection()
        {
            TestClass(typeof(ClassWithNestedDelegateWithGenericParameterBaseClassConstraint));
        }

        [TestMethod]
        public void TestClassWithNestedDelegateWithGenericParameterClassAndEmptyConstructorConstraintsUsingReflection()
        {
            TestClass(typeof(ClassWithNestedDelegateWithGenericParameterClassAndEmptyConstructorConstraints));
        }

        [TestMethod]
        public void TestClassWithNestedDelegateWithGenericParameterClassAndInterfaceAndEmptyConstructorConstraintsUsingReflection()
        {
            TestClass(typeof(ClassWithNestedDelegateWithGenericParameterClassAndInterfaceAndEmptyConstructorConstraints));
        }

        [TestMethod]
        public void TestClassWithNestedDelegateWithGenericParameterClassConstraintUsingReflection()
        {
            TestClass(typeof(ClassWithNestedDelegateWithGenericParameterClassConstraint));
        }

        [TestMethod]
        public void TestClassWithNestedDelegateWithGenericParameterEmptyConstructorConstraintUsingReflection()
        {
            TestClass(typeof(ClassWithNestedDelegateWithGenericParameterEmptyConstructorConstraint));
        }

        [TestMethod]
        public void TestClassWithNestedDelegateWithGenericParameterGenericParameterConstraintUsingReflection()
        {
            TestClass(typeof(ClassWithNestedDelegateWithGenericParameterGenericParameterConstraint));
        }

        [TestMethod]
        public void TestClassWithNestedDelegateWithGenericParameterInterfaceConstraintUsingReflection()
        {
            TestClass(typeof(ClassWithNestedDelegateWithGenericParameterInterfaceConstraint));
        }

        [TestMethod]
        public void TestClassWithNestedDelegateWithGenericParameterStructConstraintUsingReflection()
        {
            TestClass(typeof(ClassWithNestedDelegateWithGenericParameterStructConstraint));
        }

        [TestMethod]
        public void TestClassWithProtectedNestedDelegateUsingReflection()
        {
            TestClass(typeof(ClassWithProtectedNestedDelegate));
        }

        [TestMethod]
        public void TestClassWithPrivateNestedDelegateUsingReflection()
        {
            TestClass(typeof(ClassWithPrivateNestedDelegate));
        }

        [TestMethod]
        public void TestClassWithProtectedInternalNestedDelegateUsingReflection()
        {
            TestClass(typeof(ClassWithProtectedInternalNestedDelegate));
        }

        [TestMethod]
        public void TestClassWithInternalNestedDelegateUsingReflection()
        {
            TestClass(typeof(ClassWithInternalNestedDelegate));
        }

        [TestMethod]
        public void TestClassWithNestedDelegateWithParametersWithAttributesUsingReflection()
        {
            TestClass(typeof(ClassWithNestedDelegateWithParametersWithAttributes));
        }

        [TestMethod]
        public void TestClassWithNestedDelegateWithParametersWithModifiersUsingReflection()
        {
            TestClass(typeof(ClassWithNestedDelegateWithParametersWithModifiers));
        }

        [TestMethod]
        public void TestClassWithPublicNestedDelegateUsingReflection()
        {
            TestClass(typeof(ClassWithPublicNestedDelegate));
        }
    }
}
