
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;

IWebDriver driver = new ChromeDriver();

try
{
    driver.Manage().Window.Maximize();

    // Set default website URL
    string url = args.Length > 0
        ? args[0]
        : "https://app.cloudqa.io/home/AutomationPracticeForm";

    // Open website
    driver.Navigate().GoToUrl(url);

    // Wait until First Name field is visible
    WebDriverWait wait = new WebDriverWait(
        driver,
        TimeSpan.FromSeconds(10)
    );

    wait.Until(d =>
        d.FindElement(By.XPath(
            "//label[normalize-space()='First Name']/following-sibling::input"
        )).Displayed
    );

    // Find First Name field
    var firstName = driver.FindElement(
    By.XPath("//label[normalize-space()='First Name']/following-sibling::input[@type='text']")
);

    firstName.SendKeys("Mohammad");
    Console.WriteLine("PASS: First Name entered!");

    // Find Gender group
    var genderGroup = driver.FindElement(
        By.XPath("//label[normalize-space()='Gender']/following-sibling::div")
    );

    var maleRadio = driver.FindElement(
    By.XPath("//label[normalize-space()='Gender']/following-sibling::div//span[normalize-space()='Male']/preceding-sibling::input[@type='radio']")
);

    maleRadio.Click();
    Console.WriteLine("PASS: Gender selected!");

    // Find State dropdown
    var stateDropdown = driver.FindElement(
    By.XPath("//label[normalize-space()='State']/following-sibling::select")
);


    SelectElement stateSelect = new SelectElement(stateDropdown);
    stateSelect.SelectByText("India");

    Console.WriteLine("PASS: State selected!");

}
catch (NoSuchElementException ex)
{
    Console.WriteLine("FAIL: Element not found!");
    Console.WriteLine(ex.Message);
}
catch (WebDriverTimeoutException ex)
{
    Console.WriteLine("FAIL: Page or element loading timed out!");
    Console.WriteLine(ex.Message);
}
catch (Exception ex)
{
    Console.WriteLine("FAIL: An unexpected error occurred!");
    Console.WriteLine(ex.Message);
}
finally
{
    Console.WriteLine("Press Enter to close browser...");
    Console.ReadLine();

    driver.Quit();
}

Console.WriteLine("Automation execution finished.");
