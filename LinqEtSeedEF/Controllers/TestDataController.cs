using LinqEtSeedEF.Data;
using LinqEtSeedEF.Models;
using LinqEtSeedEF.ViewModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace LinqEtSeedEF.Controllers
{
    public class TestDataController : Controller
    {
        private readonly LinqEtSeedEFContext _context;
        private Random _random = new Random();

        public TestDataController(LinqEtSeedEFContext context)
        {
            _context = context;
            _random = new Random();
        }

        public async Task<IActionResult> Index()
        {
            // Faire le count après avoir transférer toutes les données
            var data = _context.TestData.ToList();
            ViewData["TotalCount"] = data.Count();
            ViewData["First100Count"] = data.Where(d => d.Id <= 100).Count();

            // Faire le count avec la BD
            /*ViewData["TotalCount"] = _context.TestData.Count();
            ViewData["First100Count"] = _context.TestData.Where(t => t.Id <= 100).Count();*/

            return View();
        }

        [HttpPost]
        public async Task<IActionResult> AddData()
        {
            int nbData = 100000;
            int maxRandomNb = nbData * 10;
            TestData[] testDatas = new TestData[nbData];

            for(int i = 0; i < testDatas.Length; i++){
                testDatas[i] = new TestData(i, _random.Next(maxRandomNb));
            }

            await _context.AddRangeAsync(testDatas);
            await _context.SaveChangesAsync();

            return RedirectToAction("Index");
        }

    }
}
