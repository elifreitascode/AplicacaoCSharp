using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Aplicacao_PROVA.Data;
using Aplicacao_PROVA.Models;

namespace Aplicacao_PROVA.Controllers
{
    public class VendasController : Controller
    {
        private readonly BancoContext _context;

        public VendasController(BancoContext context)
        {
            _context = context;
        }

        // GET: VendasModels
        public async Task<IActionResult> Index()
        {
            return View(await _context.Vendas.ToListAsync());
        }

        // GET: VendasModels/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var vendasModel = await _context.Vendas
                .FirstOrDefaultAsync(m => m.id == id);
            if (vendasModel == null)
            {
                return NotFound();
            }

            return View(vendasModel);
        }

        // GET: VendasModels/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: VendasModels/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("id,Situacao,Data,Nome_cliente,Sobrenome_cliente,Preco_da_venda")] VendasModel vendasModel)
        {
            if (ModelState.IsValid)
            {
                _context.Add(vendasModel);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(vendasModel);
        }

        // GET: VendasModels/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var vendasModel = await _context.Vendas.FindAsync(id);
            if (vendasModel == null)
            {
                return NotFound();
            }
            return View(vendasModel);
        }

        // POST: VendasModels/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("id,Situacao,Data,Nome_cliente,Sobrenome_cliente,Preco_da_venda")] VendasModel vendasModel)
        {
            if (id != vendasModel.id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(vendasModel);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!VendasModelExists(vendasModel.id))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(Index));
            }
            return View(vendasModel);
        }

        // GET: VendasModels/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var vendasModel = await _context.Vendas
                .FirstOrDefaultAsync(m => m.id == id);
            if (vendasModel == null)
            {
                return NotFound();
            }

            return View(vendasModel);
        }

        // POST: VendasModels/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var vendasModel = await _context.Vendas.FindAsync(id);
            if (vendasModel != null)
            {
                _context.Vendas.Remove(vendasModel);
            }

            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool VendasModelExists(int id)
        {
            return _context.Vendas.Any(e => e.id == id);
        }
    }
}
