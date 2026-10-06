using Microsoft.AspNetCore.Mvc;
using ToolShare.Models;

namespace ToolShare.Controllers;

public class ToolsController : Controller
{
    public IActionResult Index()
    {
        return View(ToolRepository.GetAll());
    }

    public IActionResult Details(int id)
    {
        var tool = ToolRepository.Get(id);
        if (tool == null) return NotFound();

        return View(tool);
    }

    [HttpGet]
    public IActionResult Create()
    {
        return View();
    }

    [HttpPost]
    [ValidateAntiForgeryToken]
    public IActionResult Create(Tool tool)
    {
        if (!ModelState.IsValid)
            return View(tool);

        ToolRepository.Add(tool);
        return RedirectToAction(nameof(Index));
    }

    [HttpGet]
    public IActionResult Edit(int id)
    {
        var tool = ToolRepository.Get(id);
        if (tool == null) return NotFound();

        return View(tool);
    }

    [HttpPost]
    [ValidateAntiForgeryToken]
    public IActionResult Edit(Tool tool)
    {
        if (!ModelState.IsValid)
            return View(tool);

        if (!ToolRepository.Update(tool))
            return NotFound();

        return RedirectToAction(nameof(Index));
    }

    [HttpGet]
    public IActionResult Delete(int id)
    {
        var tool = ToolRepository.Get(id);
        if (tool == null) return NotFound();

        return View(tool);
    }

    [HttpPost]
    [ValidateAntiForgeryToken]
    public IActionResult DeleteConfirmed(int id)
    {
        ToolRepository.Delete(id);
        return RedirectToAction(nameof(Index));
    }

    public IActionResult Inventory()
    {
        return View(ToolRepository.GetAll());
    }
}
