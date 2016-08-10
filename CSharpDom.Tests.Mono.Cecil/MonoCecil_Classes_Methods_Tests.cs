using CSharpDom.TestTarget.Classes.Methods;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Threading.Tasks;

namespace CSharpDom.Tests.Mono.Cecil
{
    [TestClass]
    public sealed class MonoCecil_Classes_Methods_Tests : AbstractSolutionWithMonoCecilTests
    {
        [TestMethod]
        public void TestClassWithMethodWith1AttributeUsingMonoCecil()
        {
            TestClassAsync(typeof(ClassWithMethodWith1Attribute));
        }

        [TestMethod]
        public void TestClassWithMethodWith1GenericParameterUsingMonoCecil()
        {
            TestClassAsync(typeof(ClassWithMethodWith1GenericParameter));
        }

        [TestMethod]
        public void TestClassWithMethodWith1ReturnAttributeUsingMonoCecil()
        {
            TestClassAsync(typeof(ClassWithMethodWith1ReturnAttribute));
        }

        [TestMethod]
        public void TestClassWithMethodWith2AttributesIn2AttributeGroupsUsingMonoCecil()
        {
            TestClassAsync(typeof(ClassWithMethodWith2AttributesIn2AttributeGroups));
        }

        [TestMethod]
        public void TestClassWithMethodWith2GenericParametersUsingMonoCecil()
        {
            TestClassAsync(typeof(ClassWithMethodWith2GenericParameters));
        }

        [TestMethod]
        public void TestClassWithMethodWith2ReturnAttributesIn2AttributeGroupsUsingMonoCecil()
        {
            TestClassAsync(typeof(ClassWithMethodWith2ReturnAttributesIn2AttributeGroups));
        }

        [TestMethod]
        public void TestClassWithMethodWithGenericParameterBaseClassConstraintUsingMonoCecil()
        {
            TestClassAsync(typeof(ClassWithMethodWithGenericParameterBaseClassConstraint));
        }

        [TestMethod]
        public void TestClassWithMethodWithGenericParameterClassAndEmptyConstructorConstraintsUsingMonoCecil()
        {
            TestClassAsync(typeof(ClassWithMethodWithGenericParameterClassAndEmptyConstructorConstraints));
        }

        [TestMethod]
        public void TestClassWithMethodWithGenericParameterClassAndInterfaceAndEmptyConstructorConstraintsUsingMonoCecil()
        {
            TestClassAsync(typeof(ClassWithMethodWithGenericParameterClassAndInterfaceAndEmptyConstructorConstraints));
        }

        [TestMethod]
        public void TestClassWithMethodWithGenericParameterClassConstraintUsingMonoCecil()
        {
            TestClassAsync(typeof(ClassWithMethodWithGenericParameterClassConstraint));
        }

        [TestMethod]
        public void TestClassWithMethodWithGenericParameterEmptyConstructorConstraintUsingMonoCecil()
        {
            TestClassAsync(typeof(ClassWithMethodWithGenericParameterEmptyConstructorConstraint));
        }

        [TestMethod]
        public void TestClassWithMethodWithGenericParameterGenericParameterConstraintUsingMonoCecil()
        {
            TestClassAsync(typeof(ClassWithMethodWithGenericParameterGenericParameterConstraint));
        }

        [TestMethod]
        public void TestClassWithMethodWithGenericParameterInterfaceConstraintUsingMonoCecil()
        {
            TestClassAsync(typeof(ClassWithMethodWithGenericParameterInterfaceConstraint));
        }

        [TestMethod]
        public void TestClassWithMethodWithGenericParameterStructConstraintUsingMonoCecil()
        {
            TestClassAsync(typeof(ClassWithMethodWithGenericParameterStructConstraint));
        }

        [TestMethod]
        public void TestClassWithInternalMethodUsingMonoCecil()
        {
            TestClassAsync(typeof(ClassWithInternalMethod));
        }

        [TestMethod]
        public void TestClassWithNewMethodUsingMonoCecil()
        {
            TestClassAsync(typeof(ClassWithNewMethod));
        }

        [TestMethod]
        public void TestClassWithNewStaticMethodUsingMonoCecil()
        {
            TestClassAsync(typeof(ClassWithNewStaticMethod));
        }

        [TestMethod]
        public void TestClassWithNewVirtualMethodUsingMonoCecil()
        {
            TestClassAsync(typeof(ClassWithNewVirtualMethod));
        }

        [TestMethod]
        public void TestClassWithOverrideMethodUsingMonoCecil()
        {
            TestClassAsync(typeof(ClassWithOverrideMethod));
        }

        [TestMethod]
        public void TestClassWithMethodWithParametersWithAttributesUsingMonoCecil()
        {
            TestClassAsync(typeof(ClassWithMethodWithParametersWithAttributes));
        }

        [TestMethod]
        public void TestClassWithMethodWithParametersWithModifiersUsingMonoCecil()
        {
            TestClassAsync(typeof(ClassWithMethodWithParametersWithModifiers));
        }

        [TestMethod]
        public void TestClassWithPrivateMethodUsingMonoCecil()
        {
            TestClassAsync(typeof(ClassWithPrivateMethod));
        }

        [TestMethod]
        public void TestClassWithProtectedMethodUsingMonoCecil()
        {
            TestClassAsync(typeof(ClassWithProtectedMethod));
        }

        [TestMethod]
        public void TestClassWithProtectedInternalMethodUsingMonoCecil()
        {
            TestClassAsync(typeof(ClassWithProtectedInternalMethod));
        }

        [TestMethod]
        public void TestClassWithPublicMethodUsingMonoCecil()
        {
            TestClassAsync(typeof(ClassWithPublicMethod));
        }

        [TestMethod]
        public void TestClassWithSealedOverrideMethodUsingMonoCecil()
        {
            TestClassAsync(typeof(ClassWithSealedOverrideMethod));
        }

        [TestMethod]
        public void TestClassWithStaticMethodUsingMonoCecil()
        {
            TestClassAsync(typeof(ClassWithStaticMethod));
        }

        [TestMethod]
        public void TestClassWithVirtualMethodUsingMonoCecil()
        {
            TestClassAsync(typeof(ClassWithVirtualMethod));
        }
    }
}
