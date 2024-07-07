
using Microsoft.AspNetCore.Mvc;
public class ProgramController : Controller
{
    [HttpGet]
    public IActionResult Index()
    {
        CollegeManagerDb db = new();
        var models = db.CollegePrograms.ToList();

        return View(models);
    }

    [HttpGet]
    public IActionResult Add()
    {
        return View();
    }

    [HttpPost]
    public IActionResult Add(CollegeProgram program) // model binding
    {
        // Do something on program
        CollegeManagerDb db = new();
        db.CollegePrograms.Add(program);
        db.SaveChanges();
        
        return RedirectToAction("Index");
    }

    [HttpGet]
    public IActionResult Edit(int id)
    {
        CollegeManagerDb db = new();
        var model = db.CollegePrograms.Find(id);
        return View(model);
    }

    [HttpPost]
    public IActionResult Edit(CollegeProgram program) // model binding
    {
        // Do something on program
        CollegeManagerDb db = new();
        db.CollegePrograms.Update(program);
        db.SaveChanges();
        
        return RedirectToAction("Index");
    }

    [HttpGet]
    public IActionResult Delete(int id)
    {
        CollegeManagerDb db = new();
        var model = db.CollegePrograms.Find(id);
        return View(model);
    }

    [HttpPost]
    public IActionResult Delete(CollegeProgram program) // model binding
    {
        // Do something on program
        CollegeManagerDb db = new();
        db.CollegePrograms.Remove(program);
        db.SaveChanges();
        
        return RedirectToAction("Index");
    }
}