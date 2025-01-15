# Projeto de Teste Automatizado com C#, Selenium e XUnit

Este repositório contém um exemplo de teste automatizado utilizando **Selenium WebDriver** e **XUnit**.
## Tecnologias Utilizadas

- **C#**
- **XUnit**: Framework de testes para .NET.
- **Selenium WebDriver**: Ferramenta para automação de navegadores.
- **WebDriverManager**: Gerenciador de drivers para navegadores.

## Estrutura do Teste

O teste realiza os seguintes passos:
1. Configura o driver do navegador utilizando o **WebDriverManager**.
2. Abre o navegador Google Chrome.
3. Navega até a URL `https://www.google.com.br`.
4. Verifica se o título da página é "Google".

## Código de Exemplo

```csharp
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
