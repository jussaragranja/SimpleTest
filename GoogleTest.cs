using Xunit;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using WebDriverManager;
using WebDriverManager.DriverConfigs.Impl;

public class SeleniumTest
{
    [Fact]
    public void AbrirGoogle_DeveExibirPaginaInicial()
    {

        new DriverManager().SetUpDriver(new ChromeConfig());

        using (var driver = new ChromeDriver())
        {
            driver.Navigate().GoToUrl("https://www.google.com.br");

            Assert.Equal("Google", driver.Title);
        }
    }
}