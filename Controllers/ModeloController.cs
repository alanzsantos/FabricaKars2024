using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace FabricaKars.Controllers
{
	public class ModeloController : Controller
	{
		// GET: ModeloController
		public ActionResult Index()
		{
			return View();
		}

		// GET: ModeloController/Details/5
		public ActionResult Details(int cod_modelo)
		{
			return View();
		}

		// GET: ModeloController/Create
		public ActionResult ObterDadosVeiculo()
		{
			return View();
		}

		// POST: ModeloController/Create
		[HttpPost]
		[ValidateAntiForgeryToken]
		public ActionResult ObterDadosVeiculo(IFormCollection collection)
		{
			try
			{
				return RedirectToAction(nameof(Index));
			}
			catch
			{
				return View();
			}
		}

		// GET: ModeloController/Edit/5
		public ActionResult IncluirVeiculo(int cod_modelo)
		{
			return View();
		}

		// POST: ModeloController/Edit/5
		[HttpPost]
		[ValidateAntiForgeryToken]
		public ActionResult IncluirVeiculo(int cod_modelo, IFormCollection collection)
		{
			try
			{
				return RedirectToAction(nameof(Index));
			}
			catch
			{
				return View();
			}
		}

		// GET: ModeloController/Edit/5
		public ActionResult AlterarDadosVeiculo(int cod_modelo)
		{
			return View();
		}

		// POST: ModeloController/Edit/5
		[HttpPost]
		[ValidateAntiForgeryToken]
		public ActionResult AlterarDadosVeiculo(int cod_modelo, IFormCollection collection)
		{
			try
			{
				return RedirectToAction(nameof(Index));
			}
			catch
			{
				return View();
			}
		}

		// GET: ModeloController/Delete/5
		public ActionResult ExcluirVeiculo(int cod_modelo)
		{
			return View();
		}

		// POST: ModeloController/Delete/5
		[HttpPost]
		[ValidateAntiForgeryToken]
		public ActionResult ExcluirVeiculo(int cod_modelo, IFormCollection collection)
		{
			try
			{
				return RedirectToAction(nameof(Index));
			}
			catch
			{
				return View();
			}
		}
	}
}
