using ContractManager.Data;
using ContractManager.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ModelBinding.Binders;
using Microsoft.EntityFrameworkCore;

namespace ContractManager.Controllers
{
	public class DyspozycjaController : Controller
	{
		private readonly AppDbContext _context;

		public DyspozycjaController(AppDbContext context)
		{
			_context = context;
		}

		public async Task<IActionResult> Index()
		{
			var dyspozycje = await _context.Dyspozycje.ToListAsync();

			return View(dyspozycje);
		}

		[HttpPost]
		[ValidateAntiForgeryToken]
		public async Task<IActionResult> OznaczJakoSprawdzone(int id)
		{
			var dyspozycja = await _context.Dyspozycje.FindAsync(id);
			if (dyspozycja != null)
			{
				dyspozycja.Checked = true;
				await _context.SaveChangesAsync();
			}
			return RedirectToAction(nameof(Index));
		}

		public IActionResult Create()
		{
			return View();
		}

		[HttpPost]
		public async Task<IActionResult> Create(Dyspozycja dyspozycja)
		{
			if (ModelState.IsValid)
			{
				_context.Dyspozycje.Add(dyspozycja);
				await _context.SaveChangesAsync();
				return RedirectToAction(nameof(Index));
			}
			return View(dyspozycja);
		}
	}
}
