using Microsoft.Playwright;

namespace Playwright_Project
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public async Task Test1()
        {
            var playwright = await Playwright.CreateAsync();
            var browser=await playwright.Chromium.LaunchAsync();
            var page= await browser.NewPageAsync();
            await page.GotoAsync("http://www.eaapp.somee.com");
            await page.ClickAsync("text=Login");
        }
    }
}