using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System.Security.AccessControl;

namespace DataDrivenWebDriverTests
{
    public class DataDriverTests
    {
        private WebDriver driver;
        private const string BaseUrl = "http://softuni-qa-loadbalancer-2137572849.eu-north-1.elb.amazonaws.com/number-calculator/";

        [SetUp]
        public void Setup()
        {
            driver = new ChromeDriver();
            driver.Manage().Window.Maximize();
            driver.Url = BaseUrl;
        }

        [TearDown]
        public void CloseWindow()
        {
            driver.Quit();
        
        }

        [Test]
        public void Test_Sum_2PositiveNumbers()
        {
            //Arrange
            var firstInput = driver.FindElement(By.Id("number1"));
            firstInput.SendKeys("10");

            var operationField = driver.FindElement(By.Id("operation"));
            operationField.SendKeys("+");

            var secondInput = driver.FindElement(By.Id("number2"));
            secondInput.SendKeys("2");

            var calcButton = driver.FindElement(By.Id("calcButton"));

            //Act
            calcButton.Click();

            //Assert
            var resultField = driver.FindElement(By.Id("result"));
            var expectedResult = "Result: 12";

            Assert.That(expectedResult, Is.EqualTo(resultField.Text));
        }

        [Test]
        public void Test_Sum_2NegativeNumbers()
        {
            //Arrange
            var firstInput = driver.FindElement(By.Id("number1"));
            firstInput.SendKeys("-10");

            var operationField = driver.FindElement(By.Id("operation"));
            operationField.SendKeys("+");

            var secondInput = driver.FindElement(By.Id("number2"));
            secondInput.SendKeys("-2");

            var calcButton = driver.FindElement(By.Id("calcButton"));

            //Act
            calcButton.Click();

            //Assert
            var resultField = driver.FindElement(By.Id("result"));
            var expectedResult = "Result: -12";

            Assert.That(expectedResult, Is.EqualTo(resultField.Text));
        }

        [Test]
        public void Test_Multiply_2PositiveNumbers()
        {
            //Arrange
            var firstInput = driver.FindElement(By.Id("number1"));
            firstInput.SendKeys("10");

            var operationField = driver.FindElement(By.Id("operation"));
            operationField.SendKeys("*");

            var secondInput = driver.FindElement(By.Id("number2"));
            secondInput.SendKeys("2");

            var calcButton = driver.FindElement(By.Id("calcButton"));

            //Act
            calcButton.Click();

            //Assert
            var resultField = driver.FindElement(By.Id("result"));
            var expectedResult = "Result: 20";

            Assert.That(expectedResult, Is.EqualTo(resultField.Text));
        }

        [Test]
        public void Test_Multiply_2NegativeNumbers()
        {
            //Arrange
            var firstInput = driver.FindElement(By.Id("number1"));
            firstInput.SendKeys("-10");

            var operationField = driver.FindElement(By.Id("operation"));
            operationField.SendKeys("*");

            var secondInput = driver.FindElement(By.Id("number2"));
            secondInput.SendKeys("2");

            var calcButton = driver.FindElement(By.Id("calcButton"));

            //Act
            calcButton.Click();

            //Assert
            var resultField = driver.FindElement(By.Id("result"));
            var expectedResult = "Result: -20";

            Assert.That(expectedResult, Is.EqualTo(resultField.Text));
        }

        [Test]
        public void Test_Substract_2NegativeNumbers()
        {
            //Arrange
            var firstInput = driver.FindElement(By.Id("number1"));
            firstInput.SendKeys("-10");

            var operationField = driver.FindElement(By.Id("operation"));
            operationField.SendKeys("-");

            var secondInput = driver.FindElement(By.Id("number2"));
            secondInput.SendKeys("-2");

            var calcButton = driver.FindElement(By.Id("calcButton"));

            //Act
            calcButton.Click();

            //Assert
            var resultField = driver.FindElement(By.Id("result"));
            var expectedResult = "Result: -12";

            Assert.That(expectedResult, Is.EqualTo(resultField.Text));
        }

        [Test]
        public void Test_Substract_2PositiveNumbers()
        {
            //Arrange
            var firstInput = driver.FindElement(By.Id("number1"));
            firstInput.SendKeys("10");

            var operationField = driver.FindElement(By.Id("operation"));
            operationField.SendKeys("-");

            var secondInput = driver.FindElement(By.Id("number2"));
            secondInput.SendKeys("2");

            var calcButton = driver.FindElement(By.Id("calcButton"));

            //Act
            calcButton.Click();

            //Assert
            var resultField = driver.FindElement(By.Id("result"));
            var expectedResult = "Result: 8";

            Assert.That(expectedResult, Is.EqualTo(resultField.Text));
        }
    }
}